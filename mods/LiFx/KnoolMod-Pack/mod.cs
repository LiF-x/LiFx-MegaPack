/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxKnoolModPack))
{
    new ScriptObject(LiFxKnoolModPack)
    {
    };
}

package LiFxKnoolModPack

{
    function LiFxKnoolModPack::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxKnoolModPack);
        LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks, WeaponDatablock, LiFxKnoolModPack);
        
                // Register new AI objects
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesBearKnoolCarcass(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesBearKnool(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesChieftainCarcass(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesChieftain(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesHunterCarcass(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesHunter(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesMoleCarcass(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesMole(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesWitchCarcass(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesWitch(), LiFxKnoolModPack);
                // Register new Weapon objects
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesWitchSickle(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesBearAxe(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesChieftainSword(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesHunterAxe(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesMolePickaxe(), LiFxKnoolModPack);
        LiFx::registerObjectsTypes(LiFxKnoolModPack::ObjectsTypesHunterBow(), LiFxKnoolModPack);

    }
    function LiFxKnoolModPack::version() {
        return "0.0.1";
    }
    function LiFxKnoolModPack::Datablock() {
        exec ("yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/datablocks/animals/Knools.cs");
        exec ("yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/datablocks/Weapons/datablock.cs");
    }

    function LiFxKnoolModPack::ObjectsTypesBearKnoolCarcass() {
        return new ScriptObject(ObjectsTypesBearKnoolCarcass : ObjectsTypes)
        {
            id = 2399; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "BearKnool Carcass";
            ParentID = 624;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 150;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxKnoolModPack::ObjectsTypesBearKnool() {
        return new ScriptObject(ObjectsTypesBearKnool : ObjectsTypes)
        {
            id = 2394; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Bear Knool";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesChieftainCarcass() {
        return new ScriptObject(ObjectsTypesChieftainCarcass : ObjectsTypes)
        {
            id = 2359; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Chieftain Carcass";
            ParentID = 624;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxKnoolModPack::ObjectsTypesChieftain() {
        return new ScriptObject(ObjectsTypesChieftain : ObjectsTypes)
        {
            id = 2395; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Chieftain";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    
        function LiFxKnoolModPack::ObjectsTypesHunterCarcass() {
        return new ScriptObject(ObjectsTypesHunterCarcass : ObjectsTypes)
        {
            id = 2360; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Hunter Carcass";
            ParentID = 624;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxKnoolModPack::ObjectsTypesHunter() {
        return new ScriptObject(ObjectsTypesHunter : ObjectsTypes)
        {
            id = 2396; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Hunter";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesMoleCarcass() {
        return new ScriptObject(ObjectsTypesMoleCarcass : ObjectsTypes)
        {
            id = 2361; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Mole Carcass";
            ParentID = 624;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxKnoolModPack::ObjectsTypesMole() {
        return new ScriptObject(ObjectsTypesMole: ObjectsTypes)
        {
            id = 2397; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Mole";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxKnoolModPack::ObjectsTypesWitchCarcass() {
        return new ScriptObject(ObjectsTypesWitchCarcass : ObjectsTypes)
        {
            id = 2362; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Witch Carcass";
            ParentID = 624;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxKnoolModPack::ObjectsTypesWitch() {
        return new ScriptObject(ObjectsTypesWitch : ObjectsTypes)
        {
            id = 2398; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Witch";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesWitchSickle() {
        return new ScriptObject(ObjectsTypesWitchSickle : ObjectsTypes)
        {
            id = 2461; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Witch Sickle";
            ParentID = 1031;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 1;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 1500;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/2D/Items/NativeWeapons/Witch_Sickle.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 3100;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesBearAxe() {
        return new ScriptObject(ObjectsTypesBearAxe : ObjectsTypes)
        {
            id = 2462; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Bear Axe";
            ParentID = 58;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 4; 
            MaxStackSize = 1;
            UnitWeight = 3500;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/2D/Items/NativeWeapons/bearaxe.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 7900;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesChieftainSword() {
        return new ScriptObject(ObjectsTypesChieftainSword : ObjectsTypes)
        {
            id = 2463; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Chieftain Sword";
            ParentID = 57;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 4; 
            MaxStackSize = 1;
            UnitWeight = 5000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/2D/Items/NativeWeapons/chieftainsword.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesHunterAxe() {
        return new ScriptObject(ObjectsTypesHunterAxe : ObjectsTypes)
        {
            id = 2464; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Hunter Axe";
            ParentID = 34;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 1;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/2D/Items/NativeWeapons/hunteraxe.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 3100;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesMolePickaxe() {
        return new ScriptObject(ObjectsTypesMolePickaxe : ObjectsTypes)
        {
            id = 2465; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Mole Pickaxe";
            ParentID = 35;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 1;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 1600;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/2D/Items/NativeWeapons/Molepickaxe.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 3600;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolModPack::ObjectsTypesHunterBow() {
        return new ScriptObject(ObjectsTypesHunterBow : ObjectsTypes)
        {
            id = 2466; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Hunter Bow";
            ParentID = 196;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 3000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/KnoolMod-Pack/art/2D/Items/NativeWeapons/hunterbow.png";
            Description = "A Bow of the knools, Liberated from one whom was slayed.";
            BasePrice = 20000;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
};
activatePackage(LiFxKnoolModPack);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxKnoolModPack);