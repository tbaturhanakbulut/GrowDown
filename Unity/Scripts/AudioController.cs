using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioController : MonoBehaviour
{
    public Camera camera;
    
    private void Start()
    {
        
    }
    void Update()
    {
        if(AudioCloser.i == 1)
        {
            camera.GetComponent<AudioListener>().enabled = false;

        }
        else if (AudioCloser.i == 0)
        {
            camera.GetComponent<AudioListener>().enabled = true;
        }
    }
}
