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

        [ContextMenu("Do Something")]
        private void DoSomething()
        {
            Debug.Log("Something");
        }

        void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position, "heart.png");
        }

    #endregion

    #region Private and Protected Members

    #endregion
}
