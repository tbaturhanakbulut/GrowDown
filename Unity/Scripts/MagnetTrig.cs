using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTrig : MonoBehaviour
{


    // Start is called before the first frame update
    public ParticleSystem effect;
    
    [System.NonSerialized] public static bool magnetIsTaken = false;
    Collider2D[] enemies;

    private void Awake()
    {
        magnetIsTaken = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(("Player")))
        {
            PickUp(collision);
        }
    }

    void PickUp(Collider2D player)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        FindObjectOfType<SoundManager>().Play("MagnetMetal");
        magnetIsTaken = true;
        



        Destroy(gameObject);
        


    }








}