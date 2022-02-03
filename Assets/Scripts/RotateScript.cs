using UnityEngine;
using UnityEngine.SceneManagement;
public class RotateScript : MonoBehaviour
{
    public float angularVelocity;
    // Use this for initialization
    public GameObject player;
    // Update is called once per frame
    void Start()
    {
        
        angularVelocity = Random.Range(70f, 74f);
       // player = GameObject.Find("Ball");
    }
    void Update()
    {
        transform.Rotate(0f, 0f, angularVelocity * Time.deltaTime);
        // if(player.activeSelf == false)
        // {
        //         Time.timeScale = 0f;
   
        // }
             }
    
}
