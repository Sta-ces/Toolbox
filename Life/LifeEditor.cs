using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LifeTarget))]
public class LifeEditor : Editor
{
	//private LifeTarget m_lifeTargetLife = (LifeTarget)m_targetLife;
	//private LifeTarget m_lifeMaxLife = (LifeTarget)m_maxLife;

	public override void OnInspectorGUI()
	{
        LifeTarget myTarget =  (LifeTarget) base.target;
     
		GUILayout.BeginHorizontal();
        if (GUILayout.Button("Kill"))
            myTarget.TheLife = -10;

            if (GUILayout.Button("Resurection"))
            myTarget.SetAtFullLife();
        GUILayout.EndHorizontal();
        DrawDefaultInspector();
    }
}
