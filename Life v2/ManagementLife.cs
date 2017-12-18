using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[AddComponentMenu("Character Life/Management Life")]
public class ManagementLife : MonoBehaviour
{
    #region Public Members

        [Header("Parameter Character")]
        public int m_maxHealth;

	#endregion

	#region Public void

	#endregion

	#region System

		void Start ()
		{
			
		}
	
		void Update ()
		{
			
		}

    #endregion

    #region Tools Debug And Utility

        [ContextMenu("Do Something")]
        private void DoSomething()
        {
            Debug.Log("Something");
        }

        private string m_textLabel;
        void OnGUI()
        {
            //GUILayout.Label(m_textLabel);
            m_textLabel = EditorGUI.TextField(
                            new Rect(0, 0, 100, 20),
                            "Textes de Monsieur : ",
                            m_textLabel);
        }

    #endregion

    #region Private and Protected Members

    #endregion
}
