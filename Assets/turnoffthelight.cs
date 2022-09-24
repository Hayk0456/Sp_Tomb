using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class turnoffthelight : MonoBehaviour
{
    Light2D light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<bird>().IsDead == true)
        {
            light.intensity = 0;
        }
    }
}
