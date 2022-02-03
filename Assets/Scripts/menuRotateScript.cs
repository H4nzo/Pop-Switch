using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuRotateScript : MonoBehaviour {

  public float angularVelocity;
  
    void Awake()
    {
        angularVelocity = Random.Range(100f, 115f);

	}
    void Update()
    {
        transform.Rotate(0f, 0f, angularVelocity * Time.deltaTime);
       
    }
}
