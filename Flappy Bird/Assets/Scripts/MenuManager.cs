using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public  bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    [SerializeField] public GameObject restartMenuUI;
    public bool gameFinish = false;
    void Start()
    {
        
    }

    public void PauseGame()
    {

        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    

    public void RestartGame()
    {
        {
            if(gameFinish == true)
            {
                restartMenuUI.SetActive(false);
                Time.timeScale = 1f;
                gameFinish = false;
                SceneManager.LoadScene("SampleScene");
            }
            
               
            
            
        }

    }

}

