using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour, IMan
{
    protected Animator m_animator;

    public void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    public virtual void Walk()
    {

    }

    public virtual void Jump()
    {

    }
}
