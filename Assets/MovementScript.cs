using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public GameObject targ;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float waitForSeconds = 3f;
    // Start is called before the first frame update

    private float elapsedTime = 0;
    void Update()
    {
        if(elapsedTime >= waitForSeconds)
        {
            transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, speed * Time.deltaTime);
        } else
        {
            elapsedTime += Time.deltaTime;

        }

    }

}
