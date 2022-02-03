using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour {

	public GameObject pausePanel;
	public static bool isPaused = false;
	public GameObject button;
	 //public PlayfabManager playfabManager;

	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Escape)) {
			if (isPaused) {
				Resume ();
				
			} else {
				Pause ();
			
			}
		}
	}
	public void Pause()
	{
		Time.timeScale = 0;
		button.SetActive(!true);
		pausePanel.SetActive(true);
	}
	public void Resume()
	{
			Time.timeScale = 1; 
			isPaused = false;
			button.SetActive(true);
		pausePanel.SetActive(!true);

	}
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}
		public void Quit()
	{
		SceneManager.LoadScene("menu");
		Time.timeScale = 1f;
	}
}
