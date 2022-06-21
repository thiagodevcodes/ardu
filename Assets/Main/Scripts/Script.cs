using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Material material;
    public Color cor;
    public float TempoDePiscar;
    public bool digital;
    private bool emit;
    private float time;

    public Gradient gradient;
    [Range(0, 1)] private float x;

    void Start()
    {
        material.DisableKeyword("_EMISSION");
        material.SetColor("_EmissionColor", cor);
        material.color = cor;
    }


    
    void Update()
    {
        if (digital == true)
        {
            if (time >= TempoDePiscar)
            {
                emit = !emit;
                if (emit)
                {
                    material.SetColor("_Color", cor);
                }
                else
                {
                    material.SetColor("_Color", Color.white);
                }
                time = 0f;
            }
            time += Time.deltaTime;
        } else
        {
            if (digital == false)
            {
                x += Time.deltaTime * TempoDePiscar;
                if (x > 1) x -= 1;
            }

            material.color = gradient.Evaluate(x);
        }
    }
}

    




