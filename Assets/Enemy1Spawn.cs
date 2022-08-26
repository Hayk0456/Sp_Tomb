using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Spawn : MonoBehaviour
{
    public GameObject enemy;
    public LayerMask LayersToHit;
    RaycastHit2D hit;
    LineRenderer laserline;

    // Start is called before the first frame update
    void Start()
    {
        int rand = 0;
        for (int i = 30; i < 500; i += 25)
        {
            if (Random.value < 0.5f)
                rand = 5;
            else
                rand = -5;
            Instantiate(enemy, new Vector3(rand, i, 0), new Quaternion());
        }
    }


    void Update()
    {
        if (enemy.transform.position.x < 0)
        {
         hit = Physics2D.Raycast(enemy.transform.GetChild(0).position, new Vector2(1, 0), 5000f, LayersToHit);
           
        }
        else
        {
         hit = Physics2D.Raycast(enemy.transform.GetChild(0).position, new Vector2(-1, 0), 5000f, LayersToHit);
            
        }

        if(hit)
        {
            Debug.Log("Detected");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = enemy.transform.TransformDirection(Vector3.right) * 5;
        Gizmos.DrawRay(enemy.transform.position, direction);
    }
}