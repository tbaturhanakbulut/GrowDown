using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectPlayerCircle : MonoBehaviour
{
    public ParticleSystem circleParticleSystem;

    public Transform cemberTr;
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
            ParticleSystem temp = Instantiate(circleParticleSystem, transform.position, cemberTr.rotation);

            FindObjectOfType<SoundManager>().Play("CircleExplosionSound");

            MyCamShaker.CamShake();







            temp.Play();



            Destroy(gameObject);

        }
    }
}
