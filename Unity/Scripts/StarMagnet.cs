using UnityEngine;


public class StarMagnet : MonoBehaviour
{
    Transform player;
    float distance;
    public float force = 16;
    Vector3 temp;
    Vector3 temp2;
    public float duration=1;
    float startTime;
    Rigidbody2D move;
    bool magnet=false;
    bool once = true;
    // Use this for initialization
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        move = GetComponent<Rigidbody2D>();
        temp = transform.position;
        temp2 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (MagnetTrig.magnetIsTaken|| magnet)
        {
            distance = (this.transform.position - player.transform.position).sqrMagnitude;
            if (distance < 200)
            {
                if (once)
                {
                    startTime = Time.time;
                    once = false;
                }
                //move.AddForce((player.transform.position - transform.position).normalized * (force));
                transform.position = Vector3.Slerp(temp, player.transform.position, (Time.time - startTime) / duration);
            }

        }
        if (temp2 != transform.position)
        {
            magnet = true;
        }
        

    }
   
    
}
