
using UnityEngine;



public class EnemyBlockThrower : MonoBehaviour

{

    public float speed;

    public GameObject bullet;



    private float WaitTime = 6f;

    private float time;

    public bool forceFire;
    private bool canSpawn;
    private void Start()
    {
        forceFire = true;

        time = WaitTime;

        InvokeRepeating("Fire", 0f, 6);
    }

/*    void Update()

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
*/
    private void Fire()
    {
        /*        var startRot = 180f;
                foreach (var throwable in throwables){
                    throwable.transform.position = transform.position;
                    throwable.transform.eulerAngles = new Vector3(0, 180, startRot + 30);
                    startRot += 30;
                }*/
        if (!canSpawn) return;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("asda");
        if(collision.gameObject.CompareTag("bird"))
        {
            canSpawn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bird"))
        {
            canSpawn = false;
        }
    }

}

