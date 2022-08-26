using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    public Transform target;
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
       // if (target.position.y > -6)
        //{
            transform.position = new Vector3(transform.position.x, target.position.y+4, transform.position.z);
       // }
    }
}
