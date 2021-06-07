using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillManager : MonoBehaviour
{
    private bool oneShot = false;
    public static float drillTimer = 7f;
    public static float drillSliderTimer = 0f;
    
    
    
   
    void Awake()
    {
        
        drillSliderTimer = drillTimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Drill.drillIsTaken)
        {
            
            if(oneShot == false)
            StartCoroutine(Drilliptal());

            oneShot = true;

            
            
        }

       
        
    }
    IEnumerator Drilliptal()
    {
        yield return new WaitForSeconds(drillTimer);
        Drill.drillIsTaken = false;
        oneShot = false;
        Move.mySpeed -= 12;
        FindObjectOfType<SoundManager>().Stop("DrillTheme");
        FindObjectOfType<SoundManager>().Play("DjSound");
        Invoke("Oynat", 1.2f);
        

    }
    public void Oynat()
    {
        FindObjectOfType<SoundManager>().Unpause("Theme");
    }
}
