using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public GameObject targ;
    // Start is called before the first frame update

    void Update()
    {
        transform.position = new Vector3(transform.position.x, targ.transform.position.y);
    }
}
