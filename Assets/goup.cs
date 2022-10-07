using UnityEngine;

public class Goup : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 90, 0) * speed / 6 * Time.deltaTime;
    }
}
