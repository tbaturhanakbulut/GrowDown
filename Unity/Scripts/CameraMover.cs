using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    public GameObject fellow;
    public float offSet = -4f;
    public static float initial = 10000000.0f;

    
    float duration;
    void Start()
    {
        initial = 100000000.0f;
        
    }

    void Update()
    {
        //if((Time.timeSinceLevelLoad < (initial + 1)))

        duration = (-fellow.transform.position.y)/400;
        if ((Time.timeSinceLevelLoad > initial))
        {
            reverse();// && 
            
        }



        else
        {
            Vector3 temp = transform.position;
            temp.y = fellow.transform.position.y + offSet;
            transform.position = temp;
        }

        
    }

    public void reverse()
    {
        Move.mySpeed = 0;
        Vector3 v3 = this.fellow.transform.position;
        v3.x = 0.0f;
        v3.z = -10.0f;
        transform.position = Vector3.Slerp(v3, new Vector3(0, -181, -10), (Time.timeSinceLevelLoad - initial) / duration);
        //print("time: " + ((Time.timeSinceLevelLoad-initial)/10.0f));
    }
}