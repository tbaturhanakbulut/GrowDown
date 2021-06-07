using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyDetector : MonoBehaviour
{
    bool once = true;
    //public GameData gameData;
    public GameObject playAgainScene;
    public GameObject inGameScene;
    public Transform fellow;
    public Text scoreText;
    public Text highScoreText;
    
    private void Awake()
    {

        
        Move.mySpeed = 10f;
        playAgainScene.SetActive(false);
        inGameScene.SetActive(true);
        


    }
    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            if (once)
            {
                once = false;
                CameraMover.initial = Time.timeSinceLevelLoad;
                Move.mySpeed = 0f;
                int number = (int)(-fellow.position.y - 180);
                scoreText.text = number.ToString();

                if (number > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore", number);
                    highScoreText.text = number.ToString();
                }
                
                /*if (number > int.Parse(highScoreText.text))
                {
                    highScoreText.text = number.ToString();
                    gameData.highScore = int.Parse(highScoreText.text);
                }*/
                
                


                Invoke("PlayAgain", 3);
                FindObjectOfType<SoundManager>().HalfTheSound("Theme");
                Invoke("PlaySound", 1.3f);
                Debug.Log(collision.gameObject.name);
            }
        }

    }
    public void PlaySound()
    {
        FindObjectOfType<SoundManager>().Play("GameOver");
    }
    public void PlayAgain()
    {
        playAgainScene.SetActive(true);
        
        inGameScene.SetActive(false);
        TinySauce.OnGameFinished(float.Parse(scoreText.text));



    }
}