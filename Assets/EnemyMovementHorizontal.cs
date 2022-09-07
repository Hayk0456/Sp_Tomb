using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementHorizontal : MonoBehaviour
{
    int k = 5;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 5 || transform.position.x <= -5)
        {
            k = -1 * k;
        }
        transform.Translate(k * Time.deltaTime, 0, 0);
    }
}
