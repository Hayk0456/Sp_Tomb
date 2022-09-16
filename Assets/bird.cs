using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bird : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 StartPos;
    Vector3 Force;
    public LineRenderer line;
    float cooldown;
    bool check;
    float y_veloc_control = -30f;
    Quaternion target;

    public bool IsDead = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }


    private void Update()
    {
        if(IsDead)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -70, -40));
        }
        else
        {

            y_veloc_control = -10f;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, y_veloc_control, 20f));//20f
            //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            //difference.Normalize();
            var rv = rb.velocity.normalized;
            float rotationZ = Mathf.Atan2(rv.y, rv.x) * Mathf.Rad2Deg;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (rb.velocity != Vector2.zero )
                target = Quaternion.Euler(0, 0, rotationZ - 90);
            if(target.z>-0.5 && target.z < 0.5)
            {
                rb.constraints = RigidbodyConstraints2D.None;
                //rb.centerOfMass = new Vector2(rb.centerOfMass.x, 10);
                transform.GetChild(0).rotation = Quaternion.Lerp(transform.GetChild(0).rotation, target, 4 * Time.deltaTime);

            }
            //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
            Debug.Log(rb.centerOfMass);

            //if (rb.position.x < -3) { 

            //target = Quaternion.Euler(rb.transform.rotation.x, rb.transform.rotation.y, -35);
            // rb.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 3f);
            // }
            // else if(rb.position.x > 3)
            // {
            //   Quaternion target = Quaternion.Euler(rb.transform.rotation.x, rb.transform.rotation.y, 35);
            //    rb.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 3f);

            // }

            if (Input.GetMouseButtonDown(0))
            {
                StartPos = Input.mousePosition;

            }
            if (Input.GetMouseButton(0) && !check)
            {
                Time.timeScale = 0.4f;
                cooldown = 1;
                Force = (Input.mousePosition - StartPos);
                
                /*
                if ((Force.x) > 350)
                {
                    Force.x = 350;
                }
                else if (Force.x < -350)
                {
                    Force.x = -350;
                }
                if (Force.y > 800)
                {
                    Force.y = 800;
                }
                else if (Force.y < -800)
                {
                    Force.y = -800;
                }
                */
                
            }
            if (Input.GetMouseButtonUp(0) && cooldown == 1)
            {
               // y_veloc_control = -1f;
                Time.timeScale = 1f;
                Force = new Vector3(Force.x * 0.5f, Force.y*5, 0);
                if (rb.velocity.y < -20)
                {
                    rb.AddForce(Force * 2);
                }
                else
                {
                    rb.AddForce(Force);
                }

                check = true;



            }
            if (check)
            {
                cooldown = cooldown - Time.deltaTime;
                if (cooldown < 0)
                {
                    check = false;

                }
            }
        }
       

    }

}


