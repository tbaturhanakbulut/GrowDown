using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedBar : MonoBehaviour
{
    public Slider slider;
    

    private void Start()
    {
        slider.value = Move.mySpeed;
    }
    public void SetSpeed()
    {
        slider.value = Move.mySpeed;
    }
    
}
