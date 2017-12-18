using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[AddComponentMenu("Character Life/Management Life")]
public class ManagementLife : MonoBehaviour
{
    #region Public Members

        [Header("Parameter Character")]
        public int m_characterMaxHealth;
        public int m_characterLife;

	#endregion

	#region Public void

	#endregion

	#region System

		void Awake()
		{
            m_characterLife = m_characterMaxHealth;
        }
	
		void Update ()
		{
			
		}

        void OnValidate()
        {
            m_characterLife = Mathf.Clamp(m_characterLife, 0, m_characterMaxHealth);
        }

    #endregion

    #region Tools Debug And Utility

        [ContextMenu("Focus")]
        private void FocusObject()
        {
            SceneView.lastActiveSceneView.FrameSelected();
        }

        void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position, "heart.png");
        }

    #endregion

    #region Private and Protected Members

    #endregion
}
