using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life: MonoBehaviour
{
	[Header("Life of Target (%)")]
	[Range(0,10)]
	[TooltipAttribute("Change target's life in pourcent")]
	public int m_life = 10;

	public int TheLife
	{
		get{ return m_life; }
		set{ m_life = Mathf.Clamp(value,0,10); }
	}

	public int GetTargetLife(int _percent, int _maxPercent)
	{
		return (_maxPercent*(_percent*10))/100;
	}

	public void isDead(GameObject _object)
	{
		Debug.Log(_object+" is Dead");
	}

	public void isAlive(GameObject _object)
	{
		Debug.Log(_object+" is Alive");
	}
}
