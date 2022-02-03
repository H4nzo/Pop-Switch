using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class loadingScreenScript : MonoBehaviour {

 [Header("Scene Settings")]
public string levelNumber;
public Text[] tips;
private Text temp;
public float time = 5f;
public GameObject StartButton;
public GameObject[] loadSwitch;



void Awake()
{
	Time.timeScale = 1f;
 StartCoroutine(LoadComplete(time)); loadSwitch[Random.Range(0, loadSwitch.Length)].SetActive(true);
}

IEnumerator LoadComplete(float x)
{
	//tips[Random.Range(0,tips.Length)].gameObject.SetActive(true);
	StartCoroutine(ChangeText(4.5f));
	yield return new WaitForSeconds(x);
	StartButton.SetActive(true);
}
IEnumerator ChangeText(float x)
{
	temp = tips[Random.Range(0,tips.Length)];
	temp.gameObject.SetActive(true);
	yield return new WaitForSeconds(x);
	temp.gameObject.SetActive(false);
	tips[Random.Range(0,tips.Length)].gameObject.SetActive(true);
}
public void PlayButton(){
	SceneManager.LoadScene(levelNumber);
}

}