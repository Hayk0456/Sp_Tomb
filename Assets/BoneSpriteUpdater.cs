using UnityEngine;
using UnityEngine.UI;


public class BoneSpriteUpdater : MonoBehaviour
{
    Image a;
    [SerializeField] private Sprite[] sprites;

    int point;

    void Start()
    {
        a = GetComponent<Image>();
        GameManager.Singleton.AddOnBonusCollected(() =>
        {
            point = Bird.instance.Bonus;
            Debug.Log(point);
            a.sprite = sprites[point];
        });
    }
}
