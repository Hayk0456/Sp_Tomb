using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton { get; private set; }
    public TMP_Text coinText;
    public TextMeshProUGUI youDied;
    public TextMeshProUGUI youWon;
    public Image anun;
    public Button restart;
    float restarto = 0;
    float dilate = 0;

    public Action OnBirdDied;
    public Action OnBonusCollected;
    public Action OnEnded;
    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }

        OnEnded += () =>
        {
            youWon.enabled = true;
            coinText.enabled = false;
            anun.enabled = false;
        };
    } 
    void Start()
    {
        restart.interactable = false;
        Bird.instance.GetComponent<Rigidbody2D>().isKinematic = true;
        Bird.instance.GetComponentInChildren<SpriteRenderer>().enabled = false;
        Invoke("birdenable", 4);
        AddOnBirdDied(() => {
            youDied.text = "YOU DIED";
            youDied.color = new Color(youDied.color.r, youDied.color.g, youDied.color.b, dilate);
            restart.image.color = new Color(restart.image.color.r, restart.image.color.g, restart.image.color.b, restarto);
            restart.interactable = true;
            dilate = Mathf.Lerp(dilate, 255, Time.deltaTime/25);
            restarto = Mathf.Lerp(restarto, 200, Time.deltaTime / 25);
        });
    }

    void birdenable()
    {
        Bird.instance.GetComponent<Rigidbody2D>().isKinematic = false;
        Bird.instance.GetComponentInChildren<SpriteRenderer>().enabled = true;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(Bird.instance);
        coinText.text = "Height: " + (Bird.instance.transform.position.y + 16).ToString("F0") + "cm" + "";
    }

    public void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    public void CallOnBirdDied()
    {
        OnBirdDied?.Invoke();
    }

    public void AddOnBirdDied(Action action) {
        OnBirdDied += action;
    }

    public void CallOnBonusCollected()
    {
        OnBonusCollected?.Invoke();
    }

    public void AddOnBonusCollected(Action action)
    {
        OnBonusCollected += action;
    }
    
    public void CallOnEnded()
    {
        OnEnded?.Invoke();
    }
}
