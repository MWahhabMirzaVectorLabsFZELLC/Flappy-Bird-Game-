using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { set; get; }

    public GameObject GameOverMenu;
    public GameObject PauseMenu;


    private void Start()
    {
        Instance = this;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverMenu.SetActive(true);
    }
    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
     Time.timeScale = 0;
     PauseMenu.SetActive(true);
        }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }


}

