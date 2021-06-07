using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillColorChange : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color[] myColorss;
    public float waitingTime = 5f;
    [SerializeField] [Range(0f, 20f)] float lerpTime;
    int temp = 300;
    
    float t = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {


        
        
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            int myIndex = Random.Range(0, myColorss.Length);
            
            while(temp==myIndex) {
                myIndex = Random.Range(0, myColorss.Length);
            }
            spriteRenderer.color = myColorss[myIndex];
            temp = myIndex;
            
           
            
        }



    }
    
    
    
    
}
