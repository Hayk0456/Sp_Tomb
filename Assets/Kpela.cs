using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kpela : MonoBehaviour
{
    float countdown;
    float rayscaler = 0.8953f;
    Transform ray;
    void Start()
    {
        ray = GetComponent<Transform>();

        countdown = Random.Range(0, 12);
    }
    // Start is called before the first frame update
   void Update()
    {

        if (countdown > 0)
        {
           
            if (rayscaler > 0.8953f)
            {
                rayscaler-=Time.deltaTime*3;
            }
            else
            {
                countdown -= Time.deltaTime*4;
            }

        }
        else if (countdown <= 0)
        {
            int k = Random.Range(10, 30);
            rayscaler+= Time.deltaTime*10;
            if (rayscaler >= k) {

                countdown = Random.Range(0, 11);

            }
        }
        ray.localScale = new Vector3(rayscaler/2, 0.1f, 1);
    }
}
