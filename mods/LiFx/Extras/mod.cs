/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxContainers))
{
    new ScriptObject(LiFxContainers)
    {
    };
}

package LiFxContainers

{
    function LiFxContainers::setup() {
     //   LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxContainers);
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, DbChanges, LiFxContainers);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ContChanges, LiFxContainers);
        
        // Register new objects
    //    LiFx::registerObjectsTypes(LiFxContainers::ObjectsTypesLargeTanningtub(), LiFxContainers);

    }
    function LiFxContainers::version() {
        return "1.0.0";
    }

  function LiFxContainers::ContChanges() {
    
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
    //  dbi.Update("INSERT IGNORE `recipe` VALUES (1092, 'Long House', 'A Beautiful house once home to the King of Godenland.', 32, 18, 90, 1232, 35, 1, 0, 0, 'yolauncher/modpack/art/2D/Recipies/Longhouse.png')");
     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    //dbi.update("INSERT IGNORE INTO `objects_types` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)

      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 138"); // bloomery
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 300000 WHERE ID = 107"); // furnace
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 500000 WHERE ID = 136"); // Blacksmith shop
      dbi.Update("UPDATE `objects_types` SET  Length = 6 WHERE ID = 682"); //camp fire Length allows for more items storage
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 682"); //camp fire increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 200000 WHERE ID = 453"); //Forge and anvil increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 117"); //Kiln increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 168"); //Cart increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 2000000 WHERE ID = 169"); //Trader Cart increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 6000000 WHERE ID = 1461"); //Horse Cart Tented increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 6000000 WHERE ID = 1437"); //Horse Cart Harnessed Tented increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 6000000 WHERE ID = 1496"); //Horse Cart no tent increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 6000000 WHERE ID = 1497"); //Horse Cart no tent Harnessed increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 600000 WHERE ID = 101"); // Chest
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 800000 WHERE ID = 103"); // Wardrobe
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 400000 WHERE ID = 104"); // Crate
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 600000 WHERE ID = 106"); // Barrel
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 111"); // Big Couldren
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 300000 WHERE ID = 114"); // Oven
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 300000 WHERE ID = 1110"); // Brewing Tank
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 50000000 WHERE ID = 131"); // Warehouse
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 50000000 WHERE ID = 516"); // Wooden Warehouse
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 100000000 WHERE ID = 132"); // LargeWarehouse

      //Extra rooms for houses

      dbi.Update("UPDATE `objects_types` SET  MaxStackSize = 10 WHERE ID = 146"); // small wooden house
      dbi.Update("UPDATE `objects_types` SET  MaxStackSize = 10 WHERE ID = 1055"); // small Plaster house
      dbi.Update("UPDATE `objects_types` SET  MaxStackSize = 10 WHERE ID = 1085"); // Wooden house
      dbi.Update("UPDATE `objects_types` SET  MaxStackSize = 10 WHERE ID = 147"); // Plaster house

// changes for crafting storage
// Example to Auto top off claims such as admin claims
//     dbi.Update("UPDATE `guild_lands` SET `SupportPoints` = '700000' WHERE `guild_lands`.`GuildID` = 3"); // Replace Guild id with teh guild id which you wish to top off monument

  }

  function LiFxContainers::DbChanges() {

//Perm Bans 

//  Example for auto bans or to auto grant VIP & ADMIN
//dbi.update("INSERT INTO `account` (IsActive,IsGM,SteamID,VIPFLag) VALUES (0,0,Steam ID Number HERE,0) ON DUPLICATE KEY UPDATE IsActive = 0, IsGM = 0, SteamID = Steam ID Number HERE, VIPFlag = 0;");
//dbi.update("INSERT INTO `account` (IsActive,IsGM,SteamID,VIPFLag) VALUES (1,1,Steam ID Number HERE,1) ON DUPLICATE KEY UPDATE IsActive = 0, IsGM = 0, SteamID = Steam ID Number HERE, VIPFlag = 0;");
// 

//AutoVip
  
  }
};
activatePackage(LiFxContainers);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxContainers);