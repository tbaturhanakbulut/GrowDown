using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   
    public Text scoreText;
    public GameObject fellows;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (-fellows.transform.position.y-180).ToString("0");
    }
}
