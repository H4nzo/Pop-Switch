using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderController : MonoBehaviour {

	public Slider progressBar;	
	public GameObject winUI;
	public float score;
	public float MaxValue = 10f;
	// Use this for initialization
	void Awake () {
		progressBar = GetComponent<Slider>();
		progressBar.maxValue = MaxValue;
		//score = GameObject.Find("Ball").GetComponent<offlinePlayerScript>().toFloat();
	}
	
	// Update is called once per frame
	void Update () {
			progressBar.value = (float)GameObject.Find("Ball").GetComponent<offlinePlayerScript>().score;
		
		if(progressBar.value >= progressBar.maxValue)
		{
			//Display Level Complete
			winUI.SetActive(true);
			GameObject.Find("Ball").SetActive(false);
			progressBar.gameObject.SetActive(false);
			GameObject.Find("ScoreText").SetActive(false);

		}
	}
}
