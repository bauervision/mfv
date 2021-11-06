using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;


[ExecuteInEditMode]

public class MobileFV_SwitchMesh : EditorWindow
{

    int meshVersion = 1;
    int combinedVersion = 1;
    private bool combined = false;
    public static void ShowWindow()
    {
        EditorWindow editorWindow = EditorWindow.GetWindow(typeof(MobileFV_SwitchMesh));
        editorWindow.autoRepaintOnSceneChange = true;
        editorWindow.Show();
        editorWindow.titleContent = new GUIContent("Switch Mesh");

    }


    void OnGUI()
    {
        GUILayout.BeginVertical("box", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Switch Meshes on Selected", EditorStyles.boldLabel);

        EditorGUILayout.Space();

        EditorGUILayout.EndHorizontal();
        combined = EditorGUILayout.Toggle("Switch Seasonal Version?", combined);
        meshVersion = EditorGUILayout.IntSlider("Variety Number", meshVersion, 1, 3);
        SwitchVersion(meshVersion);

        // if (GUILayout.Button("Switch Mesh", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
        // {
        //     var go = Selection.activeGameObject;
        //     if (go == null)
        //         if (EditorUtility.DisplayDialog("Heads Up", "Can't switch meshes without something selected", "OK"))
        //             return;

        //     SwitchVersion();
        // }

        if (combined)
        {
            combinedVersion = EditorGUILayout.IntSlider("Seasonal Number", combinedVersion, 1, 4);
            SwitchCombinedVersion(combinedVersion);
            // if (GUILayout.Button("Switch Seasonal Version", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
            // {
            //     var go = Selection.activeGameObject;
            //     if (go == null)
            //         if (EditorUtility.DisplayDialog("Heads Up", "Can't switch meshes without something selected", "OK"))
            //             return;

            //     // this will switch between the C1, C2, C3, and C4 versions
            //     SwitchCombinedVersion();
            // }

        }

    }


    private void SwitchMesh(GameObject thisGameObject, Mesh[] fbxMeshes, int version)
    {
        // handle the current selection
        MeshFilter mf = thisGameObject.transform.GetComponent<MeshFilter>();
        string oldMeshName;
        string newMeshName;
        // if this gameobject has a mesh filter assigned, handle the swap
        if (mf != null)
        {
            // store the name of this current mesh
            oldMeshName = mf.sharedMesh.name;
            // remove the last character from the name, ie, the version number...add on the version number we want to switch to
            newMeshName = mf.sharedMesh.name.Remove(mf.sharedMesh.name.Length - 1) + version.ToString();

            if (oldMeshName != newMeshName) // as long as the swap mesh is different, swap it
                foreach (Mesh mesh in fbxMeshes)// run through and find the source mesh we want to switch with
                    if (mesh.name == newMeshName)// if we find the name of what we want to swap with in the fbx file
                        mf.sharedMesh = mesh;// swap meshes
        }
    }

    private void SwitchCombinedMesh(GameObject thisGameObject, Mesh[] fbxMeshes, int version)
    {
        // handle the current selection
        MeshFilter mf = thisGameObject.transform.GetComponent<MeshFilter>();
        string oldMeshName;
        string newMeshName;
        // if this gameobject has a mesh filter assigned, handle the swap
        if (mf != null)
        {
            // store the name of this current mesh
            oldMeshName = mf.sharedMesh.name;
            // remove first 2 characters
            var tempName = mf.sharedMesh.name.Remove(0, 2);
            // add the updated prefix
            string prefix = "C" + version.ToString();
            newMeshName = prefix + tempName;

            if (oldMeshName != newMeshName) // as long as the swap mesh is different, swap it
                foreach (Mesh mesh in fbxMeshes)// run through and find the source mesh we want to switch with
                    if (mesh.name == newMeshName)// if we find the name of what we want to swap with in the fbx file
                        mf.sharedMesh = mesh;// swap meshes
        }
    }

    public void SwitchVersion(int version)
    {
        // load the file once, and then pass it down
        Mesh[] fbxMeshes = Resources.LoadAll<Mesh>(combined ? "Combined4Meshes" : "SourceMeshes");
        // run through all of the children of the current selection
        foreach (GameObject g in Selection.gameObjects)
        {
            SwitchMesh(g, fbxMeshes, version);

            // and now figure out if we need to switch out children of our selection
            if (g.transform.childCount > 0)
                LoopThroughChildren(g, fbxMeshes, version);
        }
    }

    public void SwitchCombinedVersion(int version)
    {
        // load the file once, and then pass it down
        Mesh[] fbxMeshes = Resources.LoadAll<Mesh>("Combined4Meshes");
        // run through all of the children of the current selection
        foreach (GameObject g in Selection.gameObjects)
        {
            //switch out our current selection
            SwitchCombinedMesh(g, fbxMeshes, version);

            // and now figure out if we need to switch out children of our selection
            if (g.transform.childCount > 0)
                LoopThroughCombinedChildren(g, fbxMeshes, version);
        }
    }


    public void LoopThroughChildren(GameObject currentGameObj, Mesh[] fbxMeshes, int version)
    {
        // we know for certain we have children at this point, so loop through them
        // and decide if we need to switch out meshes
        for (int i = 0; i < currentGameObj.transform.childCount; i++)
        {
            SwitchMesh(currentGameObj.transform.GetChild(i).gameObject, fbxMeshes, version);

            if (currentGameObj.transform.GetChild(i).transform.childCount > 0)
            {
                LoopThroughChildren(currentGameObj.transform.GetChild(i).gameObject, fbxMeshes, version);
            }
        }
    }

    public void LoopThroughCombinedChildren(GameObject currentGameObj, Mesh[] fbxMeshes, int version)
    {
        // we know for certain we have children at this point, so loop through them
        // and decide if we need to switch out meshes
        for (int i = 0; i < currentGameObj.transform.childCount; i++)
        {
            SwitchCombinedMesh(currentGameObj.transform.GetChild(i).gameObject, fbxMeshes, version);

            if (currentGameObj.transform.GetChild(i).transform.childCount > 0)
            {
                LoopThroughCombinedChildren(currentGameObj.transform.GetChild(i).gameObject, fbxMeshes, version);
            }
        }
    }


}
#endif