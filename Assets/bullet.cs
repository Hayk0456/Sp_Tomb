
using UnityEngine;



public class Bullet : MonoBehaviour
{
    public float speed;

    float bulletTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, bulletTime);
    }

    void Update()
    {
        //transform.Translate(transform.right * speed * Time.deltaTime);
        transform.position += transform.right * speed * Time.deltaTime;
    }
}