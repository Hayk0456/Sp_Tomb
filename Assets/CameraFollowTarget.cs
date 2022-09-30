using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    public Transform target;
    float timer = 0.5f;
    bird Bird;
    void Start()
    {
        Bird = FindObjectOfType<bird>();
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // if (target.position.y > -6)
        //{
        if (Bird.IsDead == false)
        {
            transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x, target.position.y+23, transform.position.z),5*Time.deltaTime);
        }
        else
        {
            timer -= Time.deltaTime;
            if(timer > 0)
                transform.position = new Vector3(transform.position.x, target.position.y + 4, transform.position.z);
        }
            
       // }
    }
}
