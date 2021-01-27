using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stipple : MonoBehaviour
{
    [Range(0, 1)]
    public float alpha = 1.0f;
    public Material material;

    private float old_alpha = 1.0f;

    void Update()
    {
        if (old_alpha != alpha)
        {
            old_alpha = alpha;
            material.SetFloat("_Stipple", alpha);
        }
    }
}
