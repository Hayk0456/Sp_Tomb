using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Bullet: MonoBehaviour

{

    public float speed;

    float bulletTime = 3f;

    // Start is called before the first frame update

    void Start()

    {

        Destroy(this.gameObject, bulletTime);

    }



    // Update is called once per frame

    void Update()

    {

        transform.position += transform.right * speed * Time.deltaTime;

    }

}