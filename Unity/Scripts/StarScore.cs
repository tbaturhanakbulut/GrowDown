using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarScore : MonoBehaviour
{
    public Text scoreText;
    public static int starCounter=0;
    public static int inGameStarCounter = 0;
    

    private void Start()
    {
        starCounter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = starCounter.ToString();
    }
}
