using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
//============================================================================
//
//			Used for Mobile ForestVision Menu Items
//
//============================================================================

public static class MobileFV_MenuItems
{

    [MenuItem("Tools/MobileFV Tools", false, 30)]
    private static void ShowTools()
    {
        MobileFV_Tools.ShowEditor();
    }

    #region Seasonal Trees
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/5 Arms", false, 30)]
    private static void CreateSeasonalTree5Arms()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Conifer Short", false, 30)]
    private static void CreateSeasonalTreeConiferShort()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_ConiferShort", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Conifer Tall", false, 30)]
    private static void CreateSeasonalTreeConiferTall()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_ConiferTall", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Conifer Young", false, 30)]
    private static void CreateSeasonalTreeConiferYoung()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_ConiferYoung", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Full Tree", false, 30)]
    private static void CreateSeasonalTreeFull()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_FullTree", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Shorty", false, 30)]
    private static void CreateSeasonalTreeShorty()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_short", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Tall Bunches", false, 30)]
    private static void CreateSeasonalTreeTallBunches()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_single", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Skinny Bunches", false, 30)]
    private static void CreateSeasonalTreeSkinnyBunches()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_SkinnyBunches", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Skinny Tall", false, 30)]
    private static void CreateSeasonalTreeSkinnyTall()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_SkinnyTall", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Tall Thin", false, 30)]
    private static void CreateSeasonalTreeTallThin()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_TallThin", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Young", false, 30)]
    private static void CreateSeasonalTreeYoung()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_young", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trees/Curved", false, 30)]
    private static void CreateSeasonalTreeCurved()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__TreeCurved", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Seasonal Trunks
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Basic", false, 30)]
    private static void CreateSeasonalTrunkBasic()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Branching", false, 30)]
    private static void CreateSeasonalTrunkBranching()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_branching_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Curvy", false, 30)]
    private static void CreateSeasonalTrunkCurvy()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_curvy_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Jungle 1", false, 30)]
    private static void CreateSeasonalTrunkJungle1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_jungle1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Jungle 2", false, 30)]
    private static void CreateSeasonalTrunkJungle2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_jungle2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Short Curved", false, 30)]
    private static void CreateSeasonalTrunkShortCurved()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_shortCurved_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Simple 2 Branch", false, 30)]
    private static void CreateSeasonalTrunkSimple2B()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_simple2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Simple 4 Branch", false, 30)]
    private static void CreateSeasonalTrunkSimple4B()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_simple4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Tall 1", false, 30)]
    private static void CreateSeasonalTrunkTall1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_tall1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Trunks/Tall 2", false, 30)]
    private static void CreateSeasonalTrunkTall2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__trunk_tall2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Seasonal Stumps
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Stumps/Tall", false, 30)]
    private static void CreateSeasonalStumpTall()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__stump1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Stumps/Short", false, 30)]
    private static void CreateSeasonalStumpShort()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__stump2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Stumps/Low", false, 30)]
    private static void CreateSeasonalStumpLow()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__stump3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Stumps/Nub", false, 30)]
    private static void CreateSeasonalStumpNub()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__stump4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Stumps/Broken", false, 30)]
    private static void CreateSeasonalStumpBroken()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__stump5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    #endregion

    #region Seasonal Branches
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/v0", false, 30)]
    private static void CreateSeasonalBranchEmptySimple()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__branch0_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/v1", false, 30)]
    private static void CreateSeasonalBranchEmptySimpleBent()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__branch1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/v2", false, 30)]
    private static void CreateSeasonalBranchEmptyBare1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__branch2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/v3", false, 30)]
    private static void CreateSeasonalBranchEmptyBare2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__branch3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/v4", false, 30)]
    private static void CreateSeasonalBranchEmptyBare3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__branch4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/Low Poly v1", false, 30)]
    private static void CreateSeasonalBranchLPBare1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__deadBranch1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/Low Poly v2", false, 30)]
    private static void CreateSeasonalBranchLPBare2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__deadBranch2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/Low Poly v3", false, 30)]
    private static void CreateSeasonalBranchLPBare3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__deadBranch3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Branches/Low Poly v4", false, 30)]
    private static void CreateSeasonalBranchLPBare4()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__deadBranch4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }



    #endregion

    #region Seasonal Cards

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Cards/Leaf Filler", false, 30)]
    private static void CreateSeasonalCardLeafFiller()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__card1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Cards/Bare Branch 1", false, 30)]
    private static void CreateSeasonalCardBB1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__emptyBranch1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }


    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Cards/Leaves 1", false, 30)]
    private static void CreateSeasonalCardLeaves1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__leaves1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }


    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Cards/Leaves 2", false, 30)]
    private static void CreateSeasonalCardLeaves2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__leaves2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Seasonal Foliage
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/LeafBunch", false, 30)]
    private static void CreateSeasonalFoliageBunch()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__leafBunch_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/v1", false, 30)]
    private static void CreateSeasonalFoliage1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__foliage1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/v2", false, 30)]
    private static void CreateSeasonalFoliage2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__foliage2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/v3", false, 30)]
    private static void CreateSeasonalFoliage3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__foliage3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/v4", false, 30)]
    private static void CreateSeasonalFoliage4()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__foliage4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/v5", false, 30)]
    private static void CreateSeasonalFoliage5()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__foliage5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/Conifer Short", false, 30)]
    private static void CreateSeasonalConiferShort()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Conifer_short", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Foliage/Conifer Long", false, 30)]
    private static void CreateSeasonalConiferLong()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Conifer_long", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Seasonal Ground Cover
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Grass/v1", false, 30)]
    private static void CreateSeasonalGrass()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__grass1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Grass/v2", false, 30)]
    private static void CreateSeasonalGrass2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__grass2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Grass/v3", false, 30)]
    private static void CreateSeasonalGrass3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__grass3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Grass/v4", false, 30)]
    private static void CreateSeasonalGrass4()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__grass4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Grass/v5", false, 30)]
    private static void CreateSeasonalGrass5()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__grass5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }


    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v1", false, 30)]
    private static void CreateSeasonalWeeds1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v2", false, 30)]
    private static void CreateSeasonalWeeds2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v3", false, 30)]
    private static void CreateSeasonalWeeds3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v4", false, 30)]
    private static void CreateSeasonalWeeds4()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v5", false, 30)]
    private static void CreateSeasonalWeeds5()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v6", false, 30)]
    private static void CreateSeasonalWeeds6()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v7", false, 30)]
    private static void CreateSeasonalWeeds7()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v8", false, 30)]
    private static void CreateSeasonalWeeds8()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Weeds/v9", false, 30)]
    private static void CreateSeasonalWeeds9()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__weed9_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }


    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Fern/Plant", false, 30)]
    private static void CreateSeasonalFern()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__fernPlant1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Seasonal/Ground Cover/Fern/Leaf", false, 30)]
    private static void CreateSeasonalFern2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__fern1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Trees
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/5 Arms", false, 30)]
    private static void CreateTree5Arms()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Conifer Short", false, 30)]
    private static void CreateTreeConiferShort()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_ConiferShort", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Conifer Tall", false, 30)]
    private static void CreateTreeConiferTall()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_ConiferTall", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Conifer Young", false, 30)]
    private static void CreateTreeConiferYoung()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_ConiferYoung", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Full Tree", false, 30)]
    private static void CreateTreeFull()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_FullTree", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Shorty", false, 30)]
    private static void CreateTreeShorty()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_short", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Tall Bunches", false, 30)]
    private static void CreateTreeTallBunches()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_single", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Skinny Bunches", false, 30)]
    private static void CreateTreeSkinnyBunches()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_SkinnyBunches", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Skinny Tall", false, 30)]
    private static void CreateTreeSkinnyTall()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_SkinnyTall", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Tall Thin", false, 30)]
    private static void CreateTreeTallThin()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_TallThin", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Young", false, 30)]
    private static void CreateTreeYoung()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Tree_young", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trees/Curved", false, 30)]
    private static void CreateTreeCurved()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_TreeCurved", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Trunks
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Basic", false, 30)]
    private static void CreateTrunkBasic()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Branching", false, 30)]
    private static void CreateTrunkBranching()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_branching_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Curvy", false, 30)]
    private static void CreateTrunkCurvy()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_curvy_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Jungle 1", false, 30)]
    private static void CreateTrunkJungle1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_jungle1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Jungle 2", false, 30)]
    private static void CreateTrunkJungle2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_jungle2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Short Curved", false, 30)]
    private static void CreateTrunkShortCurved()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_shortCurved_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Simple 2 Branch", false, 30)]
    private static void CreateTrunkSimple2B()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_simple2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Simple 4 Branch", false, 30)]
    private static void CreateTrunkSimple4B()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_simple4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Tall 1", false, 30)]
    private static void CreateTrunkTall1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_tall1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Trunks/Tall 2", false, 30)]
    private static void CreateTrunkTall2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_tall2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    #endregion

    #region Stumps
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Stumps/Tall", false, 30)]
    private static void CreateStumpTall()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_stump1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Stumps/Short", false, 30)]
    private static void CreateStumpShort()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_stump2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Stumps/Low", false, 30)]
    private static void CreateStumpLow()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_stump3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Stumps/Nub", false, 30)]
    private static void CreateStumpNub()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_stump4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Stumps/Broken", false, 30)]
    private static void CreateStumpBroken()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_stump5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    #endregion

    #region Branches
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/v0", false, 30)]
    private static void CreateBranchEmptySimple()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_branch0_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/v1", false, 30)]
    private static void CreateBranchEmptySimpleBent()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_branch1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/v2", false, 30)]
    private static void CreateBranchEmptyBare1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_branch2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/v3", false, 30)]
    private static void CreateBranchEmptyBare2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_branch3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/v4", false, 30)]
    private static void CreateBranchEmptyBare3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_branch4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/Low Poly v1", false, 30)]
    private static void CreateBranchLPBare1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_deadBranch1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/Low Poly v2", false, 30)]
    private static void CreateBranchLPBare2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_deadBranch2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/Low Poly v3", false, 30)]
    private static void CreateBranchLPBare3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_deadBranch3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Branches/Low Poly v4", false, 30)]
    private static void CreateBranchLPBare4()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_deadBranch4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    #endregion

    #region Cards

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Cards/Leaf Filler", false, 30)]
    private static void CreateCardLeafFiller()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_card", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Cards/Bare Branch 1", false, 30)]
    private static void CreateCardBB1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_emptyBranch1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }


    [MenuItem("GameObject/3D Object/Mobile FV/Original/Cards/Leaves 1", false, 30)]
    private static void CreateCardLeaves1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_leaves1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }


    [MenuItem("GameObject/3D Object/Mobile FV/Original/Cards/Leaves 2", false, 30)]
    private static void CreateCardLeaves2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_leaves2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Foliage
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/LeafBunch", false, 30)]
    private static void CreateFoliageBunch()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_leafBunch_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/v1", false, 30)]
    private static void CreateFoliage1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_foliage1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/v2", false, 30)]
    private static void CreateFoliage2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_foliage2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/v3", false, 30)]
    private static void CreateFoliage3()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_foliage3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/v4", false, 30)]
    private static void CreateFoliage4()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_foliage4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/v5", false, 30)]
    private static void CreateFoliage5()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_foliage5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/Conifer Short", false, 30)]
    private static void CreateConiferShort()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Conifer_short", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Foliage/Conifer Long", false, 30)]
    private static void CreateConiferLong()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Conifer_long", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    #endregion

    #region Ground Cover
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Ground Cover/Grass", false, 30)]
    private static void CreateGrass()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_grass", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Ground Cover/Weeds 1", false, 30)]
    private static void CreateWeeds1()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_weeds1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    [MenuItem("GameObject/3D Object/Mobile FV/Original/Ground Cover/Weeds 2", false, 30)]
    private static void CreateWeeds2()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_weeds2", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }

    [MenuItem("GameObject/3D Object/Mobile FV/Original/Ground Cover/Fern", false, 30)]
    private static void CreateFern()
    {
        Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_fernPlant1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
    }
    #endregion
}

#endif