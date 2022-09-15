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

            if (rb.position.x < -3) { 
            
                Quaternion target = Quaternion.Euler(rb.transform.rotation.x, rb.transform.rotation.y, -35);
                rb.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 3f);
            }
            else if(rb.position.x > 3)
            {
                Quaternion target = Quaternion.Euler(rb.transform.rotation.x, rb.transform.rotation.y, 35);
                rb.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 3f);

            }

            if (Input.GetMouseButtonDown(0))
            {
                StartPos = Input.mousePosition;

            }
            if (Input.GetMouseButton(0) && !check)
            {
                Time.timeScale = 0.4f;
                cooldown = 1;
                Force = (Input.mousePosition - StartPos) * 4f;

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


            }
            if (Input.GetMouseButtonUp(0) && cooldown == 1)
            {
                y_veloc_control = -1f;
                Time.timeScale = 1f;
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


