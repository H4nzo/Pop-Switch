using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{
    public float upwardForce = 10f;

    [SerializeField]
    private Rigidbody2D myRB;
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    public Color[] colors;
    public string currentColor;

    [Header("Score UI")]
    public int score = 0, highScore;
    private int timeTaken, changedInt;
    private Text scoreText;
    public Text highScoreText;
    public Text setTime, changedTime;
    

    public GameObject GameOverUI;
    public GameObject[] switchPrefabs;
    public GameObject colorChangerPrefabs;
    public float spawnPoint;

    public float time = 9f;
    public float timeLimit = 5f;
    public float timeTime;
    public GameObject particleFX, pauseButton;
    
    public GameManager gameManager;

    public float varyingTime = 10f;
  
    // Use this for initialization
    void Start()
    {
        
        myRB = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        setRandomColor();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        setTime = GameObject.Find("Time").GetComponent<Text>();
        changedTime = GameObject.Find("Change").GetComponent<Text>();
        scoreText.text = score.ToString();
        Time.timeScale = 1f;
       timeLimit = 9f;
       highScore = PlayerPrefs.GetInt("highScore");

     
      
       
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Jump") || Input.GetMouseButton(0))
        {
            myRB.velocity = Vector2.up * upwardForce;
            FindObjectOfType<audioManager>().Play("Player Tap");
        }

        timeTime = Time.timeSinceLevelLoad;
        timeTaken = (int)timeLimit;
        changedInt = (int)timeTime;

        scoreText.text = score.ToString();
        changedTime.text = "Changed: " + changedInt;
        setTime.text = "Time: " + timeTaken;

        if (timeTime > timeLimit)
        {
            StartCoroutine(changeColor(time));
            Instantiate(particleFX, transform.position, transform.rotation);
            timeLimit += 6;
        }

        if(score > highScore){
            highScore = score;
            highScoreText.text = "High Score: "+highScore.ToString();
            PlayerPrefs.SetInt("highScore", highScore);
          
        }

        VelocityChange();
    }


    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "bonusScore")
        {
            score += 6;
            Destroy(target.gameObject);
            spawnPoint = 14f;
            Instantiate(switchPrefabs[Random.Range(0, switchPrefabs.Length)], new Vector2(transform.position.x, transform.position.y + spawnPoint), transform.rotation);
            return;
        }

        if (target.tag == "Scored")
        {
            score += 2;
            Destroy(target.gameObject);
            spawnPoint = 14f;
            Instantiate(switchPrefabs[Random.Range(0, switchPrefabs.Length)], new Vector2(transform.position.x, transform.position.y + spawnPoint), transform.rotation);
            return;
        }


        if (target.tag != currentColor)
        {
            GameOverUI.SetActive(true);
            highScoreText.text = "High Score: "+PlayerPrefs.GetInt("highScore").ToString();
            scoreText.gameObject.SetActive(false);
            pauseButton.SetActive(false);
            gameObject.SetActive(false);

        }
    }
    public void setRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:

                if (currentColor == "Cyan")
                {
                    spriteRenderer.color = colors[1];
                    currentColor = "Yellow";
                }
                else
                {
                    currentColor = "Cyan";
                    spriteRenderer.color = colors[0];
                }
                break;
            case 1:
                if (currentColor == "Yellow")
                {
                    spriteRenderer.color = colors[2];
                    currentColor = "Magenta";
                }
                else
                {
                    currentColor = "Yellow";
                    spriteRenderer.color = colors[1];
                }
                break;
            case 2:
                if (currentColor == "Magenta")
                {
                    currentColor = "Pink";
                    spriteRenderer.color = colors[3];

                }
                else
                {
                    currentColor = "Magenta";
                    spriteRenderer.color = colors[2];
                }
                break;
            case 3:

                if (currentColor == "Pink")
                {
                    spriteRenderer.color = colors[0];
                    currentColor = "Cyan";
                }
                else
                {
                    currentColor = "Pink";
                    spriteRenderer.color = colors[3];
                }
                break;

        }
    }

    IEnumerator changeColor(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        setRandomColor();
        
    }

    public void VelocityChange()
    {
          float startingTime = Time.timeSinceLevelLoad;
       

        if (startingTime > varyingTime)
        {
           GameObject[] popSwitches = GameObject.FindGameObjectsWithTag("BallCollector");
          foreach (GameObject i in popSwitches)
          {
              i.GetComponent<RotateScript>().angularVelocity = i.GetComponent<RotateScript>().angularVelocity + 3f;
          }
            varyingTime = startingTime + 5;
        }
    }
    
   



}

