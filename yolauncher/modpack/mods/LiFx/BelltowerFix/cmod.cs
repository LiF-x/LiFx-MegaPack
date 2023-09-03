/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxBelltowerFix))
{
    new ScriptObject(LiFxBelltowerFix)
    {
    };
}
package LiFxBelltowerFix
{
  function LiFxBelltowerFix::setup() {
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, Registerdecmaterials, LiFxBelltowerFix);

  }
  function LiFxBelltowerFix::Registerdecmaterials() {
   //LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/BelltowerFix", "ChurchMats.cs");
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/BelltowerFix", "ChurchSounds.cs");
  }
  function LiFxBelltowerFix::path() {
    return $Con::File;
  }
};
activatePackage(LiFxBelltowerFix);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxBelltowerFix);