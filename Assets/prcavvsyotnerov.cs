using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class prcavvsyotnerov : MonoBehaviour{
    Image a;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public Sprite newSprite5;
    public Sprite newSprite6;
    int point;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        point = FindObjectOfType<bird>().boneus;
        Debug.Log(point);
        if (point == 0)
        {
            a.sprite = newSprite1;
        }
        else if (point == 1)
        {
            a.sprite = newSprite2;
        }
        else if (point == 2)
        {
            a.sprite = newSprite3;
        }
        else if (point == 3)
        {
            a.sprite = newSprite4;
        }
        else if (point == 4)
        {
            a.sprite = newSprite5;
        }
        else if (point == 5)
        {
            a.sprite = newSprite6;
        }

    }
}
