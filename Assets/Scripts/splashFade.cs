using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class splashFade : MonoBehaviour {

	public Image splashImage;
	public GameObject splashImage_2;
	IEnumerator Start () {
		splashImage.canvasRenderer.SetAlpha (0.0f);

		FadeIn ();
		yield return new WaitForSeconds (2.5f);
		FadeOut ();
		yield return new WaitForSeconds (2.5f);
		splashImage_2.SetActive(true);
	}
	void FadeIn()
	{
		splashImage.CrossFadeAlpha (1.0f, 1.5f, false);
	}
	void FadeOut()
	{
		splashImage.CrossFadeAlpha (0.0f, 2.5f, false);
	}

}
