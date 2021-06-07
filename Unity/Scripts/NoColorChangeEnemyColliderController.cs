
using UnityEngine;

public class NoColorChangeEnemyColliderController : MonoBehaviour
{
    // Start is called before the first frame update



    private void Update()
    {
        
        
        if (Drill.drillIsTaken == true)
        {

            gameObject.GetComponent<Collider2D>().isTrigger = true;

        }
        else if (Drill.drillIsTaken == false)
        {
            gameObject.GetComponent<Collider2D>().isTrigger = false;

        }


    }
    


}
