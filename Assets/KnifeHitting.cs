using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHitting : MonoBehaviour
{
    public GameObject knife;
    float rand = 0;
    bool worked = false;
    bird Bird;

    private void Start()
    {
        Bird = FindObjectOfType<bird>();
    }
    // Start is called before the first frame update
    void Update()
    {
        if(bird.instance.transform.position.y >= 1100 && !worked)
        {
            KnifeSpawn();
            worked = true;
        }
    }
    void KnifeSpawn()
    {
        rand = Random.Range(-8f, 8);
        GameObject obj = Instantiate(knife, new Vector3(Bird.transform.position.x, Bird.transform.position.y - 50, 0), new Quaternion());
        obj.transform.Rotate(new Vector3(0, 0, 45));
        Destroy(obj, 9);
    }
}
