using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

		public Image splashImage;
		public float timeOut = 1.4f;
		public Color blackColor;

	IEnumerator Start () {
		splashImage.canvasRenderer.SetAlpha (0.0f);

		FadeIn ();
		yield return new WaitForSeconds (2.5f);
		//FadeOut ();
		yield return new WaitForSeconds (timeOut);
		SceneManager.LoadScene("menu");
	}

	void FadeIn()
	{
		splashImage.CrossFadeAlpha (1.0f, 1.5f, false);
	}
	void FadeOut()
	{
		splashImage.gameObject.GetComponent<Image>().color = blackColor;
	}

}
