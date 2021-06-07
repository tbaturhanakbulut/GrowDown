using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsResetter : MonoBehaviour
{
    public GameObject text;
    Vector3 temp = new Vector3(450, -300, 0);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!text.active)
        {
            text.transform.position = temp;
        }
    }
}
