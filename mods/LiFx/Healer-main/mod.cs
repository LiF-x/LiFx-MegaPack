/**
* <author>Christophe Roblin</author>
* <email>Christophe@Roblin.no</email>
* <url>folkvangr.eu</url>
* <credits></credits>
* <description></description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/
deactivatePackage(LiFxHealer);
if (!isObject(LiFxHealer))
{
    new ScriptObject(LiFxHealer)
    {
        triggers = new SimGroup("");    
    };
}
if (!isObject(LiFxHealerTrigger))
{

  datablock TriggerData(LiFxHealerTrigger)
  {
      local = 1;
      tickPeriodMs = 10000;
      healInterval = 120;// seconds between each heal
  }; 
}
package LiFxHealer
{
  function LiFxHealer::setup() {       
      LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks, Healsetup, LiFxHealer);
      LiFx::registerCallback($LiFx::hooks::onJHStartCallbacks, disableHealer, LiFxHealer);
      LiFx::registerCallback($LiFx::hooks::onJHEndCallbacks, enableHealer, LiFxHealer);
  }
  function LiFxHealer::version() {
      return "1.0.1";
  }
  function LiFxHealer::Healsetup() {
      %npcList = LiFxUtility::findShapeFiles("mararedsickle.dts",cmChildObjectsGroup);
      foreach(%npc in %npcList) {
          %trigger = new Trigger() {
              polyhedron = "0 0 0 1.0 0.0 0.0 0.0 1.0 0.0 0.0 0.0 0.0 1.0";
              dataBlock = "LiFxHealerTrigger";
              position =  %npc.position;
              rotation = %npc.rotation;
              scale = "10 10 10";
              canSave = "1";
              canSaveDynamicFields = "1";
              radius = "5";
          };
          %trigger.setHidden(1);
          LiFxHealer.triggers.add(%trigger);
      }
  }

  function LiFxHealer::SetDisableDuringJH(%val)
  {
    if(%val == true) {
      LiFxHealer.DisableDuringJH = true;
    } else {
      LiFxHealer.DisableDuringJH = false;
    }
  }

  function LiFxHealer::disableHealer()
  {
    if(LiFxHealer.DisableDuringJH) {
      for(%i = 0; %i < LiFxHealer.triggers.getCount(); %i++) {
        %trigger = LiFxHealer.triggers.getObject(%i);
        LiFxHealer.triggers.remove(%trigger);
        %trigger.delete();
      }
    }
  }

  function LiFxHealer::enableHealer()
  {
    // enable the Heal() function after a delay of 30 minutes
    if(LiFxHealer.DisableDuringJH)
    {
      LiFxHealer.schedule(30 * 60 * 1000, "LiFxHealer::Healsetup"); // 30 minutes in milliseconds
    }
  }
  function LiFxHealer::Heal(%client)
  {
    if (LiFxHealer.DisableDuringJH)
    {
      // send a message to the player informing them that the function is disabled during JH
          %player.client.cmSendClientMessage(2475, "I have been informed to not heal Bullys during JH");
      return;
    }
    
    %player = %client.Player;

    if(%player.hasBeenHealed == null)
      %player.hasBeenHealed = 0;

    if(%player.hasBeenHealed < (getUnixTime() - LiFxHealer::getHealInterval())) {
      %player.hasBeenHealed = getUnixTime();
      %transform = %player.getTransform();
      %player.savePlayer();
      %client.cmSendClientMessage(2475, "<spop><spush><color:f8c72d>You should feel better now, so please take care of yourself<spop><spush>");
      dbi.Update("UPDATE `character` SET HardHP = 2000000000, SoftHP = 2000000000 WHERE ID =" SPC %client.charID);
      dbi.Update("UPDATE `character_wounds` SET DurationLeft = 0 WHERE CharacterId = " SPC %client.charID);
      dbi.Update("DELETE FROM `character_effects` WHERE CharacterId =" SPC %client.charID);
      %client.schedule(100, "initPlayerManager"); // schedule init player after player object is deleted    
      LiFxHealer.schedule(100,"rotatePlayer", %client, %transform);
      %player.delete(); // deletes the player object
    } else {
      %client.cmSendClientMessage(2475, ((%player.hasBeenHealed + LiFxHealer::getHealInterval()) - getUnixTime()) SPC "<spop><spush><color:c6935f>seconds until you can heal again!<spop><spush>");
    }
  }

 function LiFxHealer::getHealInterval() {
    return LiFxHealer.HealInterval;
  }
  function LiFxHealer::setHealInterval(%val) {
    %this.healInterval = %val;
  }


  function LiFxHealerTrigger::onLeaveTrigger(%this, %trigger, %player) {
    %player.client.cmSendClientMessage(2475, "<spop><spush><color:c6935f>Run along and get back into the fight!<spop><spush>");
  }
  function LiFxHealerTrigger::onEnterTrigger(%this, %trigger, %player) {
      %player.client.cmSendClientMessage(2475, "<spop><spush><color:cc9966>Come here so i can give you a rub and heal!<spop><spush>");
      LiFxHealerTrigger.schedule(10000,"checkDistance",%player, %trigger);
  }
  function LiFxHealerTrigger::onTickTrigger(%this, %trigger) {
      for(%i = 0; %i < %trigger.getNumObjects(); %i++)
      {
          %player = %trigger.getObject(%i);
          if(%player.getClassName() $= "Player")
          {
              %player.client.cmSendClientMessage(2475, %client SPC "<spop><spush><color:5fc693>You have been healed in the heal area!<spop><spush>");
          }
      }
  } 
  function LiFxHealerTrigger::checkDistance(%this, %player, %trigger) {
    %player.client.cmSendClientMessage(2475, "distance" SPC VectorDist(%player.POSITION, %trigger.POSITION));
    if(VectorDist(%player.POSITION, %trigger.POSITION) < 8.0) { //&& VectorDist(%player.POSITION, %trigger.POSITION) > 2.0) {
      LiFxHealer::Heal(%player.client);
    } else {
      %player.client.cmSendClientMessage(2475, "<spop><spush><color:7ac1cf>You are too far away, come closer so i can give you a durty rub!<spop><spush>");
    }
  }
  function LiFxheal::resetHealing(%player) {
    %player.canHeal = true; // Reset the canHeal flag for the player
  }
};
activatePackage(LiFxHealer);
LiFxHealer::setup();