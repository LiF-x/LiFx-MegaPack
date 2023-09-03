/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxKnoolPack))
{
    new ScriptObject(LiFxKnoolPack)
    {
    };
}
package LiFxKnoolPack
{
  function LiFxKnoolPack::setup() {
    LiFx::registerCallback($LiFx::hooks::onDatablockLoad, RegisterWeaponDatablock, LiFxKnoolPack);
    LiFx::registerCallback($LiFx::hooks::onDatablockLoad, RegisterKnoolDatablock, LiFxKnoolPack);
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, RegisterMaterials, LiFxKnoolPack);
  }

  function LiFxKnoolPack::RegisterWeaponDatablock() {
      LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/datablocks/Weapons", "datablock.cs");
  }

  function LiFxKnoolPack::RegisterKnoolDatablock() {
      LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/datablocks/animals", "Knools.cs");

  }

  function LiFxKnoolPack::RegisterMaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/KnoolMod-Pack", "materials.cs");
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/KnoolMod-Pack", "sounds.cs");
  }

  function LiFxKnoolPack::path() {
    return $Con::File;
  }
};
activatePackage(LiFxKnoolPack);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxKnoolPack);