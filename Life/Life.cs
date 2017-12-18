using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life: MonoBehaviour
{
	[Header("Life of Target")]
	[Range(0,10)]
	[TooltipAttribute("Change target's life")]
	public int m_life;

	public int TheLife{
		get{ return m_life; }
		set{ m_life = Mathf.Clamp(value,0,10); }
	}
}
