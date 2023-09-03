/**
* <author>Christophe Roblin & Warped Ibun</author>
* <url>lifxmod.com</url>
* <credits></credits>
* <description>Life Is Feudal Admin Oversight System - to give players transparency of admin actions, any server who does not choose to have this installed may have something to hide</description>
*/

deactivatePackage(LiFxAdminOversight);
if (!isObject(LiFxAdminOversight))
{
    new ScriptObject(LiFxAdminOversight)
    {
      LastCall = getUnixTime();
    };
}

package LiFxAdminOversight {
  function LiFxAdminOversight::setup() {
    LiFx::registerCallback($LiFx::hooks::onTick, ontick, LiFxAdminOversight);
    LiFxAdminOversight::ttmodactions();
  }
  function LiFxAdminOversight::version() {
    return "1.1.4";
  }
  function LiFxAdminOversight::ontick(%this) {
    // runs every 5 seconds
    dbi.Select(LiFxAdminOversight,"ongmaction", "SELECT AccountID,Action FROM gm_action_log WHERE ActionTimeStamp BETWEEN FROM_UNIXTIME(" @ LiFxAdminOversight.LastCall @") AND CURRENT_TIMESTAMP()");
    LiFxAdminOversight.LastCall = getUnixTime();
  }
  function LiFxAdminOversight::MessageAllWithCustomText(%this, %resultSet) {
    LiFx::debugEcho(%this SPC %resultset);
    if(%resultSet.ok() && %resultSet.nextRecord())
    {
      LiFxUtility::messageAll(2480, %resultSet.getFieldValue("Message"));
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
  
  function LiFxAdminOversight::ongmaction(%this, %resultSet) {
    if(%resultSet.ok()) {
      while (%resultSet.nextRecord()) {
        LiFx::debugEcho(%this SPC %CharID SPC %Action);
        %AccountID = %resultSet.getFieldValue("AccountID");
        %Action = %resultSet.getFieldValue("Action");
        if(
          !startsWith(%action,"TPTOPLAYER")
          &&
          !startsWith(%action,"local")
          &&
          !startsWith(%action,"system")
          &&
          !startsWith(%action,"bottom")
          &&
          !startsWith(%action,"center")
          ) {
          if (%AccountID $= "0"){
            dbi.Select(LiFxAdminOversight, "MessageAllWithCustomText", "Select 'TTmod has been used for" SPC %Action SPC "Admin is unknown' As Message");
            echo("Admin Oversight has detected Admin Actions using TTMOD: Action: " @ %action);
          }
          else {
            dbi.Select(LiFxAdminOversight, "OversightCharacter", "SELECT ID, '" @ %Action @ "' as Action FROM `character` where AccountID = " @ %AccountID);
            echo("Admin Oversight has detected the following admin command from: " @ %accountID @ ", Action: " @ %action);
          }
        }
      }
    }   
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

  function LiFxAdminOversight::OversightCharacter(%this, %resultSet){
    if(%resultSet.ok()) {
      while(%resultSet.nextRecord()) {
        %CharId = %resultSet.getFieldValue("ID");
        %Action = %resultSet.getFieldValue("Action");
        if(LiFxUtility::getPlayer(%charId))
        {
          dbi.Select(LiFxAdminOversight, "MessageAllWithCustomText", "SELECT CONCAT((SELECT CONCAT(Name, ' ',LastName) FROM `character` where ID = " @ %CharID @ "), ' Has Performed the Admin Action ',  '" @ %Action @ "',', The following action has been used by this admin ' ,(SELECT COUNT(*) FROM gm_action_log WHERE Action = '" @ %Action @ "'), ' Times') as Message");
        }
      }
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
  function LiFxAdminOversight::ttmodactions(%this) {
    dbi.select(LiFxAdminOversight, "checkTTMod", "SHOW TABLES LIKE 'nyu_rcon_schedule'");
  }
  function LiFxAdminOversight::checkTTMod(%this, %rs) {
    if(%rs.ok() && %rs.nextRecord()) {
      dbi.Update("DROP TRIGGER IF EXISTS `LiFx_ttmodactionlogging`;");
      %nyu_rcon_schedule_after_insert = "CREATE TRIGGER `LiFx_ttmodactionlogging` AFTER INSERT ON `nyu_rcon_schedule` FOR EACH ROW BEGIN\n";
      %nyu_rcon_schedule_after_insert = %nyu_rcon_schedule_after_insert @ "INSERT IGNORE `gm_action_log` (`ID`, `AccountID`, `Action`, `ActionTimestamp`) VALUES (NULL, 0, CONCAT(NEW.command, ' ', NEW.param1,  ' ', NEW.param2, ' ', NEW.detail), CURRENT_TIMESTAMP());\n";
      %nyu_rcon_schedule_after_insert = %nyu_rcon_schedule_after_insert @ "END;\n";
      dbi.Update(%nyu_rcon_schedule_after_insert);
    }
  }
};
activatePackage(LiFxAdminOversight);
