using UnityEngine;
using UnityEngine.Rendering.Universal;

public class endgame : MonoBehaviour
{


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var lights = FindObjectsOfType<Light2D>();
        foreach (var light in lights)
        {
            light.intensity = 0;
        }
        if (collision.tag == "bird")
        {
            GameManager.Singleton.CallOnEnded();
        }
    }
}
