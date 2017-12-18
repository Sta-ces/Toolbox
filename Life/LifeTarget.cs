using System;
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
		m_targetLife = GetTargetLife(TheLife, m_maxLife);
		if(isTargetAlive(gameObject,m_targetLife))
		{}
	}

	void OnValidate()
	{
		d_life = GetTargetLife(TheLife, m_maxLife);
	}

	private int m_targetLife;

    public void SetAtFullLife()
    {
       TheLife = m_maxLife;
    }

    public override void SetAsDeath()
    {
        throw new NotImplementedException();
    }

    public override void SetFullLife()
    {
        throw new NotImplementedException();
    }
}
