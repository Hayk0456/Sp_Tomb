using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class EnemyBlockThrower : MonoBehaviour

{

    public float speed;

    public GameObject bullet;



    private float WaitTime = 6f;

    private float time;

    public bool forceFire;

    // Start is called before the first frame update

    void Start()

    {

        forceFire = true;

        time = WaitTime;

        //InvokeRepeating("fire", 0f, 0.6f);

    }

    // Update is called once per frame

    void Update()

    {

        if (forceFire == true)

        {

            if (time > 0)

            {

                time -= Time.deltaTime;

            }

            else

            {

                fire();
                Debug.Log("Fired");
                time = WaitTime;

            }

        }

    }

    void fire()

    {

        int rand = Random.Range(0, 10);

        GameObject tmp1 = Instantiate(bullet, transform.position, new Quaternion());
            tmp1.transform.Rotate(new Vector3(0, 180, 180));
        GameObject tmp5 = Instantiate(bullet, transform.position, new Quaternion());
            tmp5.transform.Rotate(new Vector3(0, 180, 240));
        GameObject tmp6 = Instantiate(bullet, transform.position, new Quaternion());
        tmp6.transform.Rotate(new Vector3(0, 180, 270));
        GameObject tmp9 = Instantiate(bullet, transform.position, new Quaternion());
            tmp9.transform.Rotate(new Vector3(0, 180, 300));
        GameObject tmp11 = Instantiate(bullet, transform.position, new Quaternion());
            tmp11.transform.Rotate(new Vector3(0, 180, 360));

    }

}

