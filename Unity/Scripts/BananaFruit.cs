using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaFruit : MonoBehaviour
{
    public ParticleSystem bananaSystem;
    

    // Update is called once per frame
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(bananaSystem, transform.position, Quaternion.identity);
            StarScore.starCounter++;

            FindObjectOfType<SoundManager>().Play("StarCollectionSound");
            Destroy(gameObject);
            //CANI ARTSIN PUANI ARTSIN
            
        }
    }
}
