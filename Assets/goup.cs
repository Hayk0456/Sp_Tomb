using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goup : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       transform.position += new Vector3(0, 90, 0) * speed/12 * Time.deltaTime; 
    }
}