using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour {

	public GameObject MenuPanel, loginPanel;

	
	void Awake()
	{
		Time.timeScale = 1f;
		
	}
	public void LoginScreen()
	{
		loginPanel.SetActive(true);
		MenuPanel.SetActive(false);
	}
	
	public void Play()
	{
	SceneManager.LoadScene("loadingSceneOnline");
	  FindObjectOfType<audioManager>().Play("Player Tap");
     gameObject.GetComponent<Canvas>().enabled = false;

	}


	public void Quit()
	{
		Application.Quit();
	}
	

}
