using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCom : MonoBehaviour
{
    public float speed=10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100f) * Time.deltaTime*speed); 
    }
}
