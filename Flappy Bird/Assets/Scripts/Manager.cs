using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Text scoreText;
    public int score;


    public Text highScoreText; // -------High Score ------------

    string highScoreKey = "HighScore";  // -------High Score ------------


    MenuManager menuManager;


    void Start()
    {
        // Ekran geniþlik ve yükseklik oranýna göre nesneleri ölçeklendirir

        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float screenRatio = screenWidth / screenHeight;

        
        transform.localScale = new Vector3(screenRatio, screenRatio, screenRatio);

        // Ekran geniþlik ve yükseklik oranýna göre nesneleri ölçeklendirir


        score = 0;
        scoreText.text = "Score: " + score.ToString();

        // -------High Score ------------
        int highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = "High Score: " + highScore;
        // -------High Score ------------


        menuManager = FindObjectOfType<MenuManager>();
        
    }

    private void Update()
    {
        // -------High Score ------------
      
        int highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save();
            highScoreText.text = "High Score: " + highScore; 
        }
        // -------High Score ------------
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
     //   Debug.Log("Score: " + score);
    }

    public void GameOver()
    {
        if (menuManager.gameFinish == false)
        {
            Time.timeScale = 0f;
            menuManager.restartMenuUI.SetActive(true);
            
            menuManager.gameFinish = true;

            
        }
        

    }

}


