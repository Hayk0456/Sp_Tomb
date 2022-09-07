using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWallSlower : MonoBehaviour
{
    public Rigidbody2D bird;
 
    public void OnTriggerStay2D(Collider2D other)
    {
        var bird = other.GetComponent<Rigidbody2D>();

        if (other.gameObject.name == "bird" && FindObjectOfType<bird>().IsDead == false)
        {
            bird.velocity = new Vector2(bird.velocity.x, Mathf.Clamp(bird.velocity.y, -1, 10f));
        }


    }

 
}
