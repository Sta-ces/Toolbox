using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exemple_MenuItem : MonoBehaviour
{
	[MenuItem("ToolBoxHeader/Dis Bonjour")]
    public static void HeaderMenu()
    {
        new GameObject("Bonjour Header");
    }
    [MenuItem("Assets/ToolBoxAssets/Dis Bonjour")]
    public static void AssetsMenu()
    {
        new GameObject("Bonjour Assets");
    }
    [MenuItem("Assets/Create/ToolBoxAssetsCreate/Dis Bonjour")]
    public static void AssetsCreateMenu()
    {
        new GameObject("Bonjour Assets Create");
    }
    [MenuItem("CONTEXT/Rigidbody/Dis Bonjour")]
    public static void ScritpsMenu()
    {
        GameObject g = new GameObject("Bonjour Scripts");
    }
}
