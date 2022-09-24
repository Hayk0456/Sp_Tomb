using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    Transform bird;
    public TMP_Text cointext;
    public TextMeshProUGUI youdied;
    public Button restart;
    float dilate = 0;
    // Start is called before the first frame update
    void Start()
    {
        bird = FindObjectOfType<bird>().transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "Height: " + (bird.position.y + 16).ToString("F0") + "cm" +"";
        if(FindObjectOfType<bird>().IsDead == true)
        {
            youdied.text = "Thanks for the sacrifice" +
                "  :) :) :) :) :)";
            youdied.color = new Color(youdied.color.r, youdied.color.g, youdied.color.b, dilate);
            restart.image.color = new Color(restart.image.color.r, restart.image.color.g, restart.image.color.b, dilate);

            dilate = Mathf.Lerp(dilate, 255, Time.deltaTime/101);
            
        }
    }

}
