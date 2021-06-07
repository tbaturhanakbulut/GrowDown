using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarScoreSHOP : MonoBehaviour
{
    public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PlayerPrefs.GetInt("ShopStars", 0).ToString();
    }
}
