using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightTurner : MonoBehaviour
{
    Light2D light;
    Bird bird;
    // Start is called before the first frame update
    void Start()
    {
        bird = FindObjectOfType<Bird>();
        light = GetComponent<Light2D>();
        GameManager.Singleton.AddOnBirdDied(() =>
        {
            light.intensity = 0;
        });
    }

}
