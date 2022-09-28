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
    public TextMeshProUGUI youwon;
    public Image anun;

    public Button restart;
    float restarto = 0;
    float dilate = 0;
    public bool isended = false;
    // Start is called before the first frame update
    void Start()
    {
        bird = FindObjectOfType<bird>().transform;
        restart.interactable = false ;


    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "Height: " + (bird.position.y + 16).ToString("F0") + "cm" +"";
        if(FindObjectOfType<bird>().IsDead == true)
        {
            youdied.text = "YOU DIED";
            youdied.color = new Color(youdied.color.r, youdied.color.g, youdied.color.b, dilate);
            restart.image.color = new Color(restart.image.color.r, restart.image.color.g, restart.image.color.b, restarto);
            restart.interactable = true;
            dilate = Mathf.Lerp(dilate, 255, Time.deltaTime/101);
            restarto = Mathf.Lerp(restarto, 130, Time.deltaTime / 101);


        }

        if (isended)
        {
            anun.enabled = true;
            youwon.enabled = true;
        }
    }

}
