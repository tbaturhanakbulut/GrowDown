using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarScorePlayAgain : MonoBehaviour
{
    public static int ShopStarCounter;
    public Text text;
    private void Awake()
    {
        
        ShopStarCounter = PlayerPrefs.GetInt("ShopStars", 0);
    }
    void Start()
    {
        text.text = StarScore.starCounter.ToString();
        ShopStarCounter += StarScore.starCounter;
        Debug.Log(ShopStarCounter);
        PlayerPrefs.SetInt("ShopStars", ShopStarCounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
