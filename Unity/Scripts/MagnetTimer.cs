using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTimer : MonoBehaviour
{
    private bool oneShot = false;
    public static float magnetTimer = 10f;
    public static float magnetSliderTimer = 0f;



    void Awake()
    {
        
        magnetSliderTimer = magnetTimer;

    }

    // Update is called once per frame
    void Update()
    {
        if (MagnetTrig.magnetIsTaken)
        {

            if (oneShot == false)
                StartCoroutine(Magnetiptal());

            oneShot = true;



        }



    }
    IEnumerator Magnetiptal()
    {
        yield return new WaitForSeconds(magnetTimer);
        MagnetTrig.magnetIsTaken = false;
        oneShot = false;
        
        
        


    }
    
}
