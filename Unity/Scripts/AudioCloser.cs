using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCloser : MonoBehaviour
{
    public static  int i = 1;
    private void Awake()
    {
        
    }
    private void Start()
    {
        i = PlayerPrefs.GetInt("audio", 0);
    }
    public void OpenUp()
    {
        i = 1;
        PlayerPrefs.SetInt("audio", i);
    }
    public void CloseUp()
    {
        i = 0;
        PlayerPrefs.SetInt("audio", i);
    }





}

