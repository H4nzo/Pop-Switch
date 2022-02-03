using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countDown : MonoBehaviour {


	public int countdown = 3;
    public Text countDownText;
    public pauseScript PauseScript;

	public GameObject[] hierarchyObjects;
    public bool finished = false;

    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(StartCountDown());

    }


    IEnumerator StartCountDown()
    {
        while (countdown > 0)
        {
            countDownText.text = countdown.ToString();
            
            yield return new WaitForSeconds(1f);
            countdown --;
        }

        countDownText.text = "GO!";
        finished = true;
         
    }
    
    void Update()
    {
        if(finished ==true)
        {
            foreach (GameObject playable in hierarchyObjects)
            {
                playable.SetActive(true);
               
            } 
            GameObject.Find("Camera").SetActive(false);
            gameObject.SetActive(false);
          //  gameObject.GetComponent<Canvas>().enabled = false;
        }
    }


















}
















	// void Update () {
	// 	HeadStart();
	// }
	//  void HeadStart()
    // {
    //     Time.timeScale = 0;
    //     countdown =-Time.deltaTime;
    //     if(countdown == 0)
    //     {
    //         Time.timeScale = 1;
    //         //start the game
    //         //set Time.timeScale = 1f;
	// 		foreach (GameObject objects in hierarchyObjects)
	// 		{
	// 			objects.SetActive(true);
	// 		}
			
    //     }
    // }

	