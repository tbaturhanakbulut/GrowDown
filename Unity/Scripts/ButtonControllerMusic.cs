using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerMusic : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioCloser.i == 1)
        {
            Button1.gameObject.SetActive(false);
            Button2.gameObject.SetActive(true);
        }
        else if (AudioCloser.i == 0)
        {
            Button1.gameObject.SetActive(true);
            Button2.gameObject.SetActive(false);
        }
    }
}
