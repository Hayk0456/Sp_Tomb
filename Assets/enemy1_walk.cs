using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1_walk : MonoBehaviour
{
    Transform nazduwar;
    // Start is called before the first frame update
    void Start()
    {
        nazduwar = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        nazduwar.position = new Vector3(nazduwar.position.x, nazduwar.position.y-0.01f, nazduwar.position.z);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "bird")
        {
            FindObjectOfType<bird>().IsDead = true;
            Time.timeScale = 1f;
            Debug.Log("esel kpav");
        }
    }
}
