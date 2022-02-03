using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScriptTwo : MonoBehaviour {
  public float angularVelocity = 99.5f;
    // Use this for initialization
  public GameObject player;

  void Awake()
  {
     player = GameObject.Find("Ball");
  }
    void Update()
    {
        transform.Rotate(0f, 0f, angularVelocity * Time.deltaTime);
        if(player.activeSelf == false)
        {
          Time.timeScale = 0f;
        }
            
    }
    
}
