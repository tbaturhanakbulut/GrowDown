using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectPlayerSpike : MonoBehaviour
{
    public ParticleSystem spikeParticleSystem;


    private CamShaker MyCamShaker;


    private void Start()
    {
        MyCamShaker = GameObject.FindGameObjectWithTag("ScreenShaker").GetComponent<CamShaker>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {





        if (collision.gameObject.tag == "Player")
        {
            //Shaker.ShakeAll(MyShakePreset);
            ParticleSystem temp = Instantiate(spikeParticleSystem, transform.position, Quaternion.identity);

            FindObjectOfType<SoundManager>().Play("SpikeExplosionSound");

            MyCamShaker.CamShake();







            temp.Play();



            Destroy(gameObject);

        }
    }

}
