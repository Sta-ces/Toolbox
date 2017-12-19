using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateProjectFolder : Editor
{
    [MenuItem("ToolBox/Create/Project")]
    public static void CreateProject()
    {
        string[] Folders = { "_Scenes", "Scripts", "Materials" };
        foreach (string folder in Folders)
        {
            AssetDatabase.CreateFolder("Assets/Test", folder);
        }
        AssetDatabase.Refresh();
    }
}
