// //-----------------------------------------------------------------------------
// // Lifx: WarpedIbun
// //-----------------------------------------------------------------------------

// // Attack types:
// //  Attack1H
// //  Attack2HSword
// //  Attack2HWeapon
// //  AttackPike
// //  Attack1_2HSword
// //  AttackBow
// //  AttackCrossbow
// //  AttackThrowing
// //  AttackSpear

// // Weapon types:
// //  Weapon1_2HSword
// //  Weapon1HAxe
// //  Weapon1HMace
// //  Weapon1HSword
// //  Weapon2HAxe
// //  Weapon2HMace
// //  Weapon2HSword
// //  WeaponBow
// //  WeaponCrossbow
// //  WeaponLance
// //  WeaponPike
// //  WeaponPolearm
// //  WeaponSpear
// //  WeaponThrowing
// //  WeaponShield
// //  WeaponMisc

// // HitGroup types:
// //  Slashing
// //  Piercing
// //  Chopping
// //  Siege
// //  Blunt

 //Witch Sickle
 datablock WeaponData(WitchSickle : BaseMeleeWeapon)
 {
    id = 700; // DataBlock ID
    Object_typeID = 2461; // Objects types Database table ID
   
    shapefile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3d-2d/weapons/natives/witchsickle.dts";
   
    mountPoint = 0;
    offset = "0 0 0";
    eyeOffset = "0 0 0";

    attackType = Attack1H;
    WeaponType = WeaponMisc;
    weaponMaterial = Metal;
    hitGroupType[0] = Piercing;
    hitGroupDmgLevel[0] = 2.63;
    hitGroupType[1] =  Slashing;
    hitGroupDmgLevel[1] = 2.35;
    hitDirection[0] = "1"; // Thrust
    hitDirection[1] = "0"; // Overhead
    hitDirection[2] = "0"; // RightToLeftHit
    hitDirection[3] = "0"; // LeftToRightHit
    WoundMultiplier = 1.5;
    FractureMultiplier = 1.5;
    StunMultiplier = 0.0;
    correctMuzzleVector = false;
    className = "WeaponImage";
    item = WitchSickleItem;
 };

 datablock WeaponData(BearAxe : BaseMeleeWeapon) //based off Poll Axe
 {
    id = 702;
    Object_typeID = 2462;
    shapefile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3d-2d/weapons/natives/bearaxe.dts";
   
    mountPoint = 0;
    offset = "0 0 0";
    eyeOffset = "0 0 0";

    attackType = Attack2HWeapon;
    WeaponType = WeaponMisc;
    weaponMaterial = Metal;
    hitGroupType[0] = Piercing;
    hitGroupDmgLevel[0] = 1.85;
    hitGroupType[1] =  Chopping;
    hitGroupDmgLevel[1] = 1.4;
    hitGroupType[2] =  Blunt;
    hitGroupDmgLevel[2] = 1.0;
    hitGroupType[3] =  Blunt;
    hitGroupDmgLevel[3] = 0.5;
    hitDirection[0] = "0 3"; // Thrust
    hitDirection[1] = "1 3"; // Overhead
    hitDirection[2] = "1 3"; // RightToLeftHit
    hitDirection[3] = "1 3"; // LeftToRightHit
    WoundMultiplier = 2.5;
    FractureMultiplier = 1.3;
    StunMultiplier = 1;
    correctMuzzleVector = false;
    className = "WeaponImage";
    item = BearAxeItem;
    BasePrefireAnimTime = 1.1;
    BaseFireAnimTime = 1.0;
    BaseRecoilAnimTime = 1.1;
 };

datablock WeaponData(KnoolChieftainSword : BaseMeleeWeapon) //Based Off Practice Long Sword
{
   id = 750;
   Object_typeID = 2463;
   
   shapefile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3d-2d/weapons/natives/C2_Sword.dts";
   

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   weaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.9;
   hitGroupType[1] = Slashing;
   hitGroupDmgLevel[1] = 1.65;
   hitGroupType[2] = Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0"; // Thurst
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LefttoRightHit
   WoundMultiplier = 3.5;
   FractureMultiplier = 2.3;
   StunMultiplier = 1.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ZweihaenderItem;
   BasePrefireAnimTime = 1;
   BaseFireAnimTime = 1;
   BaseRecoilAnimTime = 0.8;
};

 datablock WeaponData(HunterAxe : BaseMeleeWeapon) //based off Nordic axe
 {
    id = 704;
    Object_typeID = 2464;
   
    shapefile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3d-2d/weapons/natives/hunteraxe.dts";
   
    mountPoint = 0;
    offset = "0 0 0";
    eyeOffset = "0 0 0";

    attackType = Attack1H;
    WeaponType = WeaponMisc;
    weaponMaterial = Metal;
    hitGroupType[0] = Piercing;
    hitGroupDmgLevel[0] = 2.35;
    hitGroupType[1] =  Chopping;
    hitGroupDmgLevel[1] = 1.74;
    hitGroupType[2] =  Blunt;
    hitGroupDmgLevel[2] = 1.0;
    hitDirection[0] = "0"; // Thrust
    hitDirection[1] = "1.2"; // Overhead
    hitDirection[2] = "1.2"; // RightToLeftHit
    hitDirection[3] = "1.2"; // LeftToRightHit
    WoundMultiplier = 1.8;
    FractureMultiplier = 1;
    StunMultiplier = 1;
    correctMuzzleVector = false;
    className = "WeaponImage";
    item = HunterAxeItem;

    BasePrefireAnimTime = 1.1;
    BaseFireAnimTime = 1.0;
    BaseRecoilAnimTime = 1.1;
 };

 datablock WeaponData(MolePickaxe : BaseMeleeWeapon) // based off steel picaxe
 {
    id = 705;
    Object_typeID = 2465;
   
    shapeFile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3d-2d/weapons/natives/molepickaxe.dts";
   
    mountPoint = 0;
    offset = "0 0 0";
    eyeOffset = "0 0 0";

    attackType = Attack1H;
    WeaponType = WeaponMisc;
    weaponMaterial = Wooden;
    hitGroupType[0] = Piercing;
    hitGroupDmgLevel[0] = 2.5;
    hitGroupType[1] =  Slashing;
    hitGroupDmgLevel[1] = 1.8;
    hitGroupType[2] =  Blunt;
    hitGroupDmgLevel[2] = 1.5;
    hitGroupType[3] =  Blunt;
    hitGroupDmgLevel[3] = 1.5;
    hitDirection[0] = "1"; // Thrust
    hitDirection[1] = "0"; // Overhead
    hitDirection[2] = "0"; // RightToLeftHit
    hitDirection[3] = "0"; // LeftToRightHit
    WoundMultiplier = 1.5;
    FractureMultiplier = 1.2;
    StunMultiplier = 1.0;
    correctMuzzleVector = false;
    className = "WeaponImage";
    item = MolePickaxeItem;
 };

 datablock RangedWeaponData(HunterBow : BaseBow) //based off composite bow
 {
    id = 706;
    Object_typeID = 2466;

    AgilityNeed = 50.0;
    StrengthNeed = 45.0;
    MaxAccuracy = 1.3;
    Emax = 5.9;
    BasePrefireAnimTime = 1.3;
    BaseRecoilAnimTime = 1.2;
    allowedAmmoIDs = "656 657 658 659 660 1339 1582";
    DurabilityPerShot = 22.0;
    StaminaRate = 20.0;

    shapefile = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/Models/3d-2d/weapons/natives/hunterbow.dts";

    mountPoint = 0;
    offset = "0 0 0";
    eyeOffset = "0 0 0";

    attackType = AttackBow;
    WeaponType = WeaponBow;
    item = HunterBowItem;

    hitDirection[0] = ""; // Thrust
    hitDirection[1] = ""; // Overhead
    hitDirection[2] = ""; // RightToLeftHit
    hitDirection[3] = "1"; // LeftToRightHit
    WoundMultiplier = "3";
    FractureMultiplier = "";
    StunMultiplier = "";
    correctMuzzleVector = false;
 };