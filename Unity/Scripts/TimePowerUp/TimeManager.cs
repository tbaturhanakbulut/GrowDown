using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowTimeFactor = 0.05f;
    public float slowTimeLength = 2f;
    private void Update()
    {
        
        Time.timeScale += (1f / slowTimeLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
    public void DoSlowMotion()
    {
        Time.timeScale = slowTimeFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.2f;
    }


}
