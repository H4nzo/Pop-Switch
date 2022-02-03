using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgChanger : MonoBehaviour {

	public Sprite[] BGs;
	public float fixedTime = 5f;
	public float visibleTime;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Image>().sprite = BGs[0];
	}
	
	// Update is called once per frame
	void Update () {
			visibleTime = Time.time;
		if(Time.time > fixedTime)
		{
			 StartCoroutine(changeBG(0.01f));
			 fixedTime = Time.time + 8;
		}
		

	}

	 IEnumerator changeBG(float time)
	 {
		 yield return new WaitForSecondsRealtime(time);
		 gameObject.GetComponent<Image>().sprite = BGs[Random.Range(0, BGs.Length)];
	}
}
