using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUpBar : MonoBehaviour
{
    public Slider drillSlider;
    public Slider magnetSlider;
    public GameObject ingamedrillbar;
    public GameObject ingamemagnetbar;
    float magnettemp;
    float drilltemp;
    public Gradient gradi;
    public Image fill;
    public Image magnetFill;
    float timeElapsed=0f;
    float magnettimeElapsed = 0f;
    bool once = true;
    bool twice = true;

    private void Start()
    {
        drillSlider.maxValue = DrillManager.drillTimer;
        magnetSlider.maxValue = MagnetTimer.magnetTimer;
        
        
    }
    public void Update()
    {
       
 if (Drill.drillIsTaken)
        {
            ingamedrillbar.gameObject.SetActive(true);
            
            if (once)
            {
                drillSlider.value = drillSlider.maxValue;
                fill.color = gradi.Evaluate(1f);
                once = false;
                drilltemp = drillSlider.value;
                timeElapsed = 0f;

                
            }
            drillSlider.value = Mathf.Lerp(drilltemp, 0, timeElapsed / DrillManager.drillTimer);
            fill.color = gradi.Evaluate(drillSlider.normalizedValue);
            timeElapsed += Time.deltaTime;
        }
        else
        {
            ingamedrillbar.gameObject.SetActive(false);
            once = true;
        }
        if (MagnetTrig.magnetIsTaken)
        {
            
            ingamemagnetbar.gameObject.SetActive(true);
            if (twice)
            {
                magnetSlider.value = magnetSlider.maxValue;
                magnetFill.color = gradi.Evaluate(1f);
                twice = false;
                magnettemp = magnetSlider.value;
                magnettimeElapsed = 0f;
            }
            magnettimeElapsed += Time.deltaTime / MagnetTimer.magnetTimer;
            
            
            magnetSlider.value = Mathf.Lerp(magnettemp, 0, magnettimeElapsed);
            magnetFill.color = gradi.Evaluate(magnetSlider.normalizedValue);
            
            
        }
        else
        {
            ingamemagnetbar.gameObject.SetActive(false);
            twice = true;
        }

        
    }


}
