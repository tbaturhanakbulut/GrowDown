using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPoisonScript : MonoBehaviour
{
    private bool isEnabled = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            FindObjectOfType<SpeedMan>().TakeDamage(3);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            FindObjectOfType<SpeedMan>().TakeDamage(3);
        }
    }

}
