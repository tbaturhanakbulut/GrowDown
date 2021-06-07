using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    

    // Start is called before the first frame update
    public ParticleSystem effect;
    private float timer = 5f;
    private float number = 2f;
    [System.NonSerialized] public static bool drillIsTaken=false;
    Collider2D[] enemies;

    private void Awake()
    {
        drillIsTaken = false;
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
        drillIsTaken = true;
        Move.mySpeed += 12;
        FindObjectOfType<SoundManager>().Pause("Theme");
        FindObjectOfType<SoundManager>().Play("DrillTheme");



        Destroy(gameObject);
        
        
    }
    
    
   

   



}