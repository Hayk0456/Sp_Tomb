using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class turnoffthelight : MonoBehaviour
{
    Light2D light;
    bird Bird;
    // Start is called before the first frame update
    void Start()
    {
        Bird = FindObjectOfType<bird>();
        light = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Bird.IsDead)
        {
            light.intensity = 0;
        }
    }
}
