using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Life : MonoBehaviour
{
    [Header("Life of Target (%)")]
    [Range(0, 10)]
    [TooltipAttribute("Change target's life in pourcent")]
    [SerializeField]
    private int m_life = 10;

    public int TheLife
    {
        get { return m_life; }
        set { m_life = Mathf.Clamp(value, 0, 10); }
    }

    public int GetTargetLife(int _percent, int _maxPercent)
    {
        return (_maxPercent * (_percent * 10)) / 100;
    }

    public void isDead(GameObject _object)
    {
        Debug.Log(_object + " is Dead");
    }

    public void isAlive(GameObject _object)
    {
        Debug.Log(_object + " is Alive");
    }

    public bool isTargetAlive(GameObject _object, int _targetLife)
    {
        bool result;
        if (_targetLife <= 0)
        {
            isDead(gameObject);
            result = false;
        }
        else
        {
            isAlive(gameObject);
            result = true;
        }
        return result;
    }

    public virtual void SetAsDeath() {
        _onDeath.Invoke();
    }
    public abstract void SetFullLife();

    public UnityEvent _onDeath;
}
