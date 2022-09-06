using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kpav : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "bird")
        {
            if (!GetterisDead())
            {
                SetterisDead(true);
            }
            Debug.Log("esel kpav");
        }
    }
}
