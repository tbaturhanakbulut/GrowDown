using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParticleEffectPlayer : MonoBehaviour
{
    public ParticleSystem boxParticleSystem;
    SpriteRenderer spriteRenderer;

    private CamShaker MyCamShaker;
    private void Start()
    {
        MyCamShaker = GameObject.FindGameObjectWithTag("ScreenShaker").GetComponent<CamShaker>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        var bpS = boxParticleSystem;
        var vs = boxParticleSystem.shape;
        var vse = boxParticleSystem.emission;
        
        bpS.startColor = spriteRenderer.color;
        vs.scale = new Vector3((transform.localScale.x)/3, transform.localScale.y, 1);

        vse.SetBursts(
            new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 25*transform.localScale.y),
                
            });






        if (collision.gameObject.tag == "Player")
        {
            //Shaker.ShakeAll(MyShakePreset);
            ParticleSystem temp = Instantiate(boxParticleSystem, transform.position, Quaternion.identity);
            if (transform.localScale.y > 2)
            {
                FindObjectOfType<SoundManager>().Play("BoxBreakingSoundBig");
            }
            else {
                FindObjectOfType<SoundManager>().Play("BoxBreakingSound");
            }
            
            
            MyCamShaker.CamShake();
            
               
                
                
                    
                    
            
            temp.Play();
            

            
            Destroy(gameObject);

        }
    }

}
