using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTarget : Life
{
	[Header("Target's Params")]
	public int m_maxLife = 50;

	[Header("Debug")]
	public int d_life;

	void Awake()
	{}

	void Update()
	{
		m_targetLife = GetTargetLife(m_life, m_maxLife);
		if(m_targetLife <= 0)
			isDead(gameObject);
		else
			isAlive(gameObject);
	} 

	void OnValidate()
	{
		d_life = GetTargetLife(m_life, m_maxLife);
	}

	private int m_targetLife;
}
