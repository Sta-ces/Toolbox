using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ManagementLife))]
public class Editor_ManagementLife : Editor
{
    public override void OnInspectorGUI()
    {
        ManagementLife myTarget = (ManagementLife)base.target;
        DrawDefaultInspector();
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Set the max life"))
            myTarget.m_characterLife = myTarget.m_characterMaxHealth;
        GUILayout.EndHorizontal();
    }
}
