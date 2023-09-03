/**
* <author>Warped ibun & Kurai Sereph</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Witches from mmo introduced to Lif:YO using grouse</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

datablock AnimalData(WitchData : DefaultPlayerData)
{
    id = 780; // has to be globally unique currently this replaces the bear id
    animalTypeId = 2398; // This is dataBlock for wild animal
    footprintTexture = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Textures/AnimalFootprints/Tribe_Witch_fs.png";
    footprintTextureLinearSize = 0.4;
    footprintGap = 0.6;
    footprintTrackWidth = 0.4;
    shapeFile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3D/Mobiles/WildAnimals/Tribe_Witch.dts";
    soundFilesPrefix = "wolf";
    behavior = "yolauncher/modpack/data/ai/Tribe_Witch.xml";
    boundingBox = "1 2.4 1.8";
    runSurfaceAngle = 50;
    maxHP = 650;
    hpRegenRate = 2;
    bodyRadius = 2.5;
    rawCorpseObjectTypeID = 2362;
    skinnedCorpseObjectTypeID = 928;
    WeaponData = "Wolf_Fang";
    weaponWeight = 12;
    powerHitStartingDistance = 1.2;
    powerHitDamagingDistance = 1.4;
    powerHitDamagingSector = 90;
    powerHitMinSpeed = 15;
    powerHitMaxSpeed = 25;
    fastHitStartingDistance = 1.2;
    fastHitDamagingDistance = 1.4;
    fastHitDamagingSector = 90;
    fastHitMinSpeed = 10;
    fastHitMaxSpeed = 12;
    walkAnimationSpeed = 1.72;
    runAnimationSpeed = 1.21;
    walkSpeed = 3;
    runSpeed = 6;
    animalType = "Predator";
};

datablock AnimalData(BearKnoolData : DefaultPlayerData)
{
    id = 783; // has to be globally unique currently this replaces the bear id
    animalTypeId = 2394; // This is dataBlock for wild animal
    footprintTexture = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Textures/AnimalFootprints/Tribe_Witch_fs.png";
    footprintTextureLinearSize = 0.4;
    footprintGap = 0.6;
    footprintTrackWidth = 0.4;
    shapeFile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3D/Mobiles/WildAnimals/Tribe_BearKnool.dts";
    soundFilesPrefix = "wolf";
    behavior = "yolauncher/modpack/data/ai/Tribe_Bear.xml";
    boundingBox = "1 2.4 1.8";
    runSurfaceAngle = 50;
    maxHP = 650;
    hpRegenRate = 5;
    bodyRadius = 2.5;
    rawCorpseObjectTypeID = 2399;
    skinnedCorpseObjectTypeID = 928;
    WeaponData = "Wolf_Fang";
    weaponWeight = 12;
    powerHitStartingDistance = 1.2;
    powerHitDamagingDistance = 1.4;
    powerHitDamagingSector = 90;
    powerHitMinSpeed = 15;
    powerHitMaxSpeed = 20;
    fastHitStartingDistance = 1.2;
    fastHitDamagingDistance = 1.4;
    fastHitDamagingSector = 90;
    fastHitMinSpeed = 10;
    fastHitMaxSpeed = 12;
    walkAnimationSpeed = 1.72;
    runAnimationSpeed = 1.21;
    walkSpeed = 3;
    runSpeed = 6;
    animalType = "Predator";
};

datablock AnimalData(ChieftainData : DefaultPlayerData)
{
    id = 1025; // has to be globally unique currently this replaces the bear id
    animalTypeId = 2395; // This is dataBlock for wild animal
    footprintTexture = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Textures/AnimalFootprints/Tribe_Witch_fs.png";
    footprintTextureLinearSize = 0.4;
    footprintGap = 0.6;
    footprintTrackWidth = 0.4;
    shapeFile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3D/Mobiles/WildAnimals/tribe_chieftain.dts";
    soundFilesPrefix = "wolf";
    behavior = "yolauncher/modpack/data/ai/Tribe_Chieftain.xml";
    boundingBox = "1 2.4 1.8";
    runSurfaceAngle = 50;
    maxHP = 650;
    hpRegenRate = 9;
    bodyRadius = 2.5;
    rawCorpseObjectTypeID = 2359;
    skinnedCorpseObjectTypeID = 928;
    WeaponData = "KnoolChieftainSword";
    weaponWeight = 12;
    powerHitStartingDistance = 1.2;
    powerHitDamagingDistance = 1.4;
    powerHitDamagingSector = 90;
    powerHitMinSpeed = 15;
    powerHitMaxSpeed = 25;
    fastHitStartingDistance = 1.2;
    fastHitDamagingDistance = 1.4;
    fastHitDamagingSector = 90;
    fastHitMinSpeed = 10;
    fastHitMaxSpeed = 12;
    walkAnimationSpeed = 1.72;
    runAnimationSpeed = 1.21;
    walkSpeed = 3;
    runSpeed = 6;
    animalType = "Predator";
};

datablock AnimalData(HunterData : DefaultPlayerData)
{
    id = 782; // has to be globally unique currently this replaces the bear id
    animalTypeId = 2396; // This is dataBlock for wild animal
    footprintTexture = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Textures/AnimalFootprints/Tribe_Witch_fs.png";
    footprintTextureLinearSize = 0.4;
    footprintGap = 0.6;
    footprintTrackWidth = 0.4;
    shapeFile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3D/Mobiles/WildAnimals/tribe_hunter.dts";
    soundFilesPrefix = "wolf";
    behavior = "yolauncher/modpack/data/ai/Tribe_Hunter.xml";
    boundingBox = "1 2.4 1.8";
    runSurfaceAngle = 50;
    maxHP = 650;
    hpRegenRate = 4;
    bodyRadius = 2.5;
    rawCorpseObjectTypeID = 2360;
    skinnedCorpseObjectTypeID = 928;
    WeaponData = "Wolf_Fang";
    weaponWeight = 12;
    powerHitStartingDistance = 1.2;
    powerHitDamagingDistance = 1.4;
    powerHitDamagingSector = 90;
    powerHitMinSpeed = 15;
    powerHitMaxSpeed = 25;
    fastHitStartingDistance = 1.2;
    fastHitDamagingDistance = 1.4;
    fastHitDamagingSector = 90;
    fastHitMinSpeed = 10;
    fastHitMaxSpeed = 12;
    walkAnimationSpeed = 1.72;
    runAnimationSpeed = 1.21;
    walkSpeed = 3;
    runSpeed = 6;
    animalType = "Predator";
};

datablock AnimalData(MoleData : DefaultPlayerData)
{
    id = 781; // has to be globally unique currently this replaces the bear id
    animalTypeId = 2397; // This is dataBlock for wild animal
    footprintTexture = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Textures/AnimalFootprints/Tribe_Witch_fs.png";
    footprintTextureLinearSize = 0.4;
    footprintGap = 0.6;
    footprintTrackWidth = 0.4;
    shapeFile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3D/Mobiles/WildAnimals/tribe_mole.dts";
    soundFilesPrefix = "wolf";
    behavior = "yolauncher/modpack/data/ai/tribe_mole.xml";
    boundingBox = "1 2.4 1.8";
    runSurfaceAngle = 50;
    maxHP = 650;
    hpRegenRate = 3;
    bodyRadius = 2.5;
    rawCorpseObjectTypeID = 2361;
    skinnedCorpseObjectTypeID = 928;
    WeaponData = "Wolf_Fang";
    weaponWeight = 12;
    powerHitStartingDistance = 1.2;
    powerHitDamagingDistance = 1.4;
    powerHitDamagingSector = 90;
    powerHitMinSpeed = 15;
    powerHitMaxSpeed = 25;
    fastHitStartingDistance = 1.2;
    fastHitDamagingDistance = 1.4;
    fastHitDamagingSector = 90;
    fastHitMinSpeed = 10;
    fastHitMaxSpeed = 12;
    walkAnimationSpeed = 1.72;
    runAnimationSpeed = 1.21;
    walkSpeed = 3;
    runSpeed = 6;
    animalType = "Predator";
};