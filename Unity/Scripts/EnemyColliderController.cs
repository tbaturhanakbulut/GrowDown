using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderController : MonoBehaviour
{
    // Start is called before the first frame update


    SpriteRenderer playerSpriteRenderer;

    [SerializeField] [Range(0f, 5f)] float lerpTime;
    int colorIndex = 0;
    float t = 0f;
    [SerializeField] Color[] myColors;
    private void Start()
    {
        playerSpriteRenderer=GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        playerSpriteRenderer.color = Color.Lerp(playerSpriteRenderer.color, myColors[colorIndex], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            if (colorIndex >= myColors.Length - 1)
                colorIndex = 0;
        }
        if (Drill.drillIsTaken == true)
        {
            
            gameObject.GetComponent<Collider2D>().isTrigger = true;
           
        }
        else if (Drill.drillIsTaken == false) 
        {
            gameObject.GetComponent<Collider2D>().isTrigger = false;

        }


    }

    

}
