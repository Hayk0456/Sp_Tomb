using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public Button restart;
    //public void ResetTheGame()
    //{
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
    // Start is called before the first frame update
    void Start()
    {
        restart = GetComponent<Button>();
        restart.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
