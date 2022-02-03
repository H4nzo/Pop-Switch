using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollector : MonoBehaviour {


void OnTriggerEnter2D(Collider2D target)
{
	if(target.tag == "BallCollector")
	{
		Destroy(target.gameObject);
	}
}
}
