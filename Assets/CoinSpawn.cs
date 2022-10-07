using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin1;
    float k = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 500; i += 20)
        {
            k = Random.RandomRange(-15, 15);
            Instantiate(coin1, new Vector3(k, i, 0), new Quaternion());
        }
    }
}
