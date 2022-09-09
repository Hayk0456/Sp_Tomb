using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kpav : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "bird")
        {
            FindObjectOfType<bird>().IsDead = true;
            Time.timeScale = 1f;
            Debug.Log("esel kpav");
        }
    }
}
