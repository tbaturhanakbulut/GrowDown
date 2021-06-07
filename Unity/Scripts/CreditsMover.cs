using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMover : MonoBehaviour
{
    Vector3 temp = new Vector3(450,0,0);
    public GameObject text;
    public float moveSpeed;
    void Start()
    {
        temp.y = -300;
        text.transform.position = temp;

    }

    // Update is called once per frame
    void Update()
    {
        temp = text.transform.position;
        temp.y += moveSpeed*Time.deltaTime;
        text.transform.position = temp;
    }
}
