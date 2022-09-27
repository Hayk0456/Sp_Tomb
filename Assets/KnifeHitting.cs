using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHitting : MonoBehaviour
{
    public GameObject knife;
    float rand = 0;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("KnifeSpawn", 0, 5);
    }
    void KnifeSpawn()
    {
        rand = Random.Range(-8f, 8);
        GameObject obj = Instantiate(knife, new Vector3(FindObjectOfType<bird>().transform.position.x, FindObjectOfType<bird>().transform.position.y - 50, 0), new Quaternion());
        obj.transform.Rotate(new Vector3(0, 0, 45));
        Destroy(obj, 9);
    }
}
