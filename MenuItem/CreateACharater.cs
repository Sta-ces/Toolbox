using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateACharacter : MonoBehaviour
{
    [MenuItem("ToolBoxHeader/Characters/Standard Character")]
    public static void HeaderMenu()
    {
        CreateCharacter();
    }
    [MenuItem("Assets/ToolBoxAssets/Characters/Standard Character")]
    public static void AssetsMenu()
    {
        CreateCharacter();
    }
    [MenuItem("Assets/Create/ToolBoxAssetsCreate/Characters/Standard Character")]
    public static void AssetsCreateMenu()
    {
        CreateCharacter();
    }
    public static void CreateCharacter()
    {
        GameObject g = new GameObject("Character");
        g.AddComponent<ManagementLife>();
    }
}
