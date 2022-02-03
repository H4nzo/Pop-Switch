using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool restartGame = false;

    public int HighScore;
    public Text highScoreText;

   

    //public static GameManager instance;
  
    void Start()
    {   
	//	PlayerPrefs.DeleteAll();
        HighScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = "High Score: " + HighScore.ToString();

    }
	
    public void Restart()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1f;
        restartGame = true;
        // Destroy(GameObject.Find("MenuCanvas"));

    }
    public void Quit()
    {
        Application.Quit();
    }
    public  void GameQuit()
    {
        SceneManager.LoadScene("menu"); Time.timeScale = 1f;
    }

}
