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
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "bird")
        {
            Debug.Log("Kpela araaaa vateees");
        }

      
    }
   void Update()
    {
        Debug.Log(countdown);
        if (countdown > 0)
        {
           
            if (rayscaler > 0.8953f)
            {
                rayscaler-=Time.deltaTime*10;
            }
            else
            {
                countdown -= Time.deltaTime;
            }

        }
        else if (countdown <= 0)
        {
            rayscaler+= Time.deltaTime * 10;
            if (rayscaler >= 50) {

                countdown = Random.Range(0, 11);

            }
        }
        ray.localScale = new Vector3(rayscaler, 0.1f, 1);
    }
}
