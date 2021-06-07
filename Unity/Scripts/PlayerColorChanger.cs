using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer playerSpriteRenderer;
    [SerializeField] [Range(0f, 100f)] float lerpTime;
    int colorIndex = 0;
    float t = 0f;
    [SerializeField] Color[] myColors;
    void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Drill.drillIsTaken)
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
        }
        else
        {
            playerSpriteRenderer.color = Color.white;
        }
    }
}
