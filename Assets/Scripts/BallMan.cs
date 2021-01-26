using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMan : Man
{

    public override void Walk()
    {
        if (m_animator == null) return;

        m_animator.SetBool("IsWalking", true);
    }

    public override void Jump()
    {
        if (m_animator == null) return;

    }
}
