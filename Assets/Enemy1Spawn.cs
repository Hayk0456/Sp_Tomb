using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    public LayerMask LayersToHit;
    RaycastHit2D hit;
    LineRenderer laserline;


    // Start is called before the first frame update
    void Start()
    {
        int rand = 0;
        for (int i = 30; i < 500; i += 15)
        {
            if (Random.value < 0.5f)
                rand = 5;
            else
                rand = -5;
            Instantiate(enemy, new Vector3(rand, i, 0), new Quaternion());
        }
        for (int i = 45; i < 500; i += 30)
        {
            if (Random.value < 0.5f)
                rand = 5;
            else
                rand = -5;
            Instantiate(enemy2, new Vector3(rand, i, 0), new Quaternion());
        }
    }

}