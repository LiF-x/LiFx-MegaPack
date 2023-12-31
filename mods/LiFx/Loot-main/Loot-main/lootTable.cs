
///////////////////////////////////////Loot Table /////////////////////////////////////////////
// Add dbi Update commands to populate the loot table for the mod as shown in the below example
//
//  Chance is relative to each other, 0 means it is not lootable (disabled)
// 
//  Example:
//  Drop 1 has Chance 1
//  Drop 2 has Chance 2
// Please ensure Max quantity is treated as stack size in the event they are stackable, if they are not stackable set at 1
//  Drop 2 is then twice more likely to be dropped than Drop 1 (2/1)
// CHIEFTAIN
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 282, 20, 100, 2, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1699, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1388, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1344, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1060, 20, 100, 10, 15, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1059, 20, 100, 2, 15, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1422, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1061, 20, 100, 1, 2, 100)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 2463, 20, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 342, 20, 100, 10, 100, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 822, 20, 100, 1, 1, 1000)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1003, 20, 100, 1, 15, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 486, 20, 100, 1, 5, 1000)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 497, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 38, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 39, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 267, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1634, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1635, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1636, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 416, 20, 100, 1, 2, 2000)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 49, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 44, 60, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1467, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1468, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1471, 80, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 559, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 556, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 569, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 592, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1101, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1102, 40, 100, 1, 1, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1103, 40, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 262, 40, 100, 1, 5, 5)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 261, 40, 100, 1, 25, 8)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 404, 60, 100, 1, 5, 20000)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1523, 80, 100, 1, 1, 10)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 1522, 80, 100, 1, 1, 5)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 617, 80, 100, 1, 1, 10)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2359, 603, 80, 100, 1, 1, 10)");



//mole
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 282, 20, 100, 2, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1699, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1388, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1344, 20, 100, 1, 3, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1060, 20, 100, 10, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1059, 20, 100, 2, 15, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1422, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 48, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1466, 60, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 417, 1, 30, 1, 3, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 418, 1, 30, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 417, 25, 80, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 418, 58, 80, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 267, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1634, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1635, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1636, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 416, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 49, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 487, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 492, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 494, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 495, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 496, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 497, 20, 50, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 498, 50, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 498, 10, 50, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 39, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 44, 60, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1467, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1468, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1471, 80, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 559, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 556, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 569, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 592, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1101, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1102, 40, 100, 1, 1, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 1103, 40, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 262, 40, 100, 1, 5, 5)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 261, 40, 100, 1, 25, 8)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 499, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2361, 404, 20, 100, 1, 2, 2500)");


 //HUNTER
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 282, 20, 100, 2, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1699, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1388, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1344, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1060, 20, 100, 10, 15, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1059, 20, 100, 2, 15, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 38, 20, 100, 1, 2, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 44, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 254, 20, 100, 1, 10, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 342, 20, 100, 1, 5, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 343, 20, 100, 1, 5, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 344, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 345, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 351, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 350, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 349, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 2464, 20, 100, 1, 1, 2)"); //hunter axe
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1422, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 267, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1634, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1635, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1636, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 416, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 44, 60, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1467, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1468, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1471, 80, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 559, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 556, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 569, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 592, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1101, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1102, 40, 100, 1, 1, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1103, 40, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 262, 40, 100, 1, 5, 5)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 261, 40, 100, 1, 25, 8)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 603, 80, 100, 1, 1, 10)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 604, 80, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 602, 80, 100, 1, 1, 10)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 601, 80, 100, 1, 1, 10)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2360, 1101, 80, 100, 1, 10, 4)");

// WITCH
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 282, 20, 100, 2, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1699, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1388, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1344, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1060, 20, 100, 10, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1104, 20, 100, 1, 3, 200)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1059, 20, 100, 2, 15, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1031, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 305, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 683, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 359, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1422, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 267, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 704, 20, 100, 1, 50, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 301, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 705, 20, 100, 1, 50, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 578, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 580, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 667, 20, 100, 1, 20, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 668, 20, 100, 1, 30, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 681, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 686, 20, 100, 20, 100, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 687, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 688, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 689, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 690, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 691, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 692, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 702, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 779, 20, 100, 1, 50, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 947, 20, 100, 1, 50, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 948, 20, 100, 1, 10, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 949, 20, 100, 1, 10, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 950, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 945, 20, 100, 1, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1634, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1635, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1636, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 416, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1467, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1471, 80, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 559, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 556, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 569, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 592, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1101, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1102, 40, 100, 1, 1, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 1103, 40, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 262, 40, 100, 1, 5, 5)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2362, 261, 40, 100, 1, 25, 8)");
//BearKnool
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 282, 20, 100, 2, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1699, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1388, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1344, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1060, 20, 100, 10, 15, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1059, 20, 100, 2, 15, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1422, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 267, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 38, 20, 100, 2, 10, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 39, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 281, 20, 100, 1, 3, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 282, 20, 100, 1, 3, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1356, 20, 100, 10, 60, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 556, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1422, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 267, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1634, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1635, 20, 100, 1, 2, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1636, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1636, 20, 100, 1, 2, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 44, 60, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1467, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1468, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1471, 80, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 559, 20, 100, 1, 1, 3)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 556, 20, 100, 1, 1, 1)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 569, 20, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 592, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1101, 40, 100, 1, 1, 2)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1102, 40, 100, 1, 1, 4)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 1103, 40, 100, 1, 1, 6)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 262, 40, 100, 1, 5, 5)");
dbi.Update("INSERT IGNORE `" @ LiFxLoot::loottable() @ "` VALUES (2399, 261, 40, 100, 1, 25, 8)");
