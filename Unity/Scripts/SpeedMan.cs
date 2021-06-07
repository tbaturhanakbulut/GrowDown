using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMan : MonoBehaviour
{
    public SpeedBar speedBar;
    public float t = 0;
    public void TakeDamage(int damage)
    {
        Move.mySpeed += damage;
        speedBar.SetSpeed();


    }
    private void Update()
    {
        
        t = Mathf.Lerp(t, 1f, Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            Move.mySpeed += 0.2f;
            speedBar.SetSpeed();
        }
    }

}
