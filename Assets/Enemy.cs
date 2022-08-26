using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public LayerMask LayersToHit;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

        if (hit)
        {
            Debug.Log("Detected");
        }

    }
    //private void OnDrawGizmos()
    //{
      //  Gizmos.color = Color.red;
        //Vector3 direction = enemy.transform.TransformDirection(Vector3.right) * 5;
        //Gizmos.DrawRay(enemy.transform.position, direction);
    //}

}
