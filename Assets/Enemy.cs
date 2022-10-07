using UnityEngine;


public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject sparrow;
    public LayerMask LayersToHit;
    Transform ray;
    RaycastHit2D hit;
    float countdown;
    float rayscaler = 0.8953f;
    // Start is called before the first frame update
    void Start()
    {
        ray = enemy.transform.Find("ray");

        countdown = Random.Range(20, 70);
    }

    // Update is called once per frame
    void Update()
    {


        //if(countdown > 0)
        //{
        // countdown -= Time.deltaTime;
        //while(rayscaler > 0.8953f)
        //{
        //  rayscaler--;
        //}

        //}
        //else if(countdown <= 0)
        //{
        //rayscaler++;
        //countdown = Random.Range(0, 11);
        //}
        // ray.localScale = new Vector3(rayscaler += 0.001f, 0.1f, 1);
        //Debug.Log(rayscaler);
    }
}
