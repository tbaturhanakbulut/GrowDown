using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTİme : MonoBehaviour
{
    public static float slowTimeRate = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player")){
            Destroy(gameObject);
            SlowEffect();
            FindObjectOfType<SoundManager>().Play("FreezeSound");
        }
    }
    void SlowEffect()
    {

        Move.mySpeed -= slowTimeRate;


    }
}