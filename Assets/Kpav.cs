using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kpav : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "bird")
        {
            if (FindObjectOfType<bird>().isarmored == false)
            { 
                FindObjectOfType<bird>().IsDead = true;
                Time.timeScale = 1f;
                Debug.Log("esel kpav");
            }
            else
            {
                FindObjectOfType<bird>().isarmored = false;
                FindObjectOfType<bird>().boneus = 0;
                FindObjectOfType<bird>().armor.SetActive(false);


            }

        }

    }
}
