using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneSpawner : MonoBehaviour
{
    public GameObject bone;
    float rand = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BoneSpawn", 0, 15);
    }

    // Update is called once per frame
    void BoneSpawn()
    {
        rand = Random.Range(-10f, 10);
        GameObject obj = Instantiate(bone, new Vector3(rand, FindObjectOfType<bird>().transform.position.y + 70, 0), new Quaternion());
        Destroy(obj, 5);
    }
}
