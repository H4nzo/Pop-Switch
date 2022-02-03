using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform player;
  
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    // Update is called once per frame
    void Update()
    {
        
        if (player.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
            // GameObject.Find("SwitchSpawner").GetComponent<Spawner>().Spawn();
        }
        
       
    }
}
