using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour {
	

public void Next()
{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	Time.timeScale = 1f;
}

public void Prev()
{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
}

public void Home()
{
	SceneManager.LoadScene("menu");
	Time.timeScale = 1f;
}

public void Restart()
{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
}


}
