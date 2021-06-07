/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInitializer : MonoBehaviour
{
    [SerializeField] private List<Transform> powerUpList;
    
    
    Transform transformLevel;
   
    void Start()
    {
        transformLevel = GetComponent<Transform>();
        SpawnPowerUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnPowerUp()
    {
        int chosenNumber;
        
        
        chosenNumber = Random.Range(0, 30);
        if (chosenNumber >= 0 && chosenNumber < powerUpList.Count)
        {
            Transform chosenPowerUp = powerUpList[chosenNumber];
            Vector3 spawnPosition = transformLevel.Find("powerUpPosition").position;
            SpawnPowerUp(chosenPowerUp, spawnPosition);
        }
        
        
       
        
        

    
    }
    private void SpawnPowerUp(Transform powerUp, Vector3 spawnPosition)
    {
        Instantiate(powerUp, spawnPosition, Quaternion.identity);
        
      
    }

}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInitializer : MonoBehaviour
{
    public static Vector3 lastPos= new Vector3 (0,-200,0);
    float length = 800;
    [SerializeField] private List<Transform> powerUpList;

    Transform transformLevel;

    void Start()
    {
        transformLevel = GetComponent<Transform>();
        SpawnPowerUp();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnPowerUp()
    {
        Vector3 spawnPosition = transformLevel.Find("powerUpPosition").position;
        if ((spawnPosition - lastPos).magnitude > length)
        {
            Transform chosenPowerUp = powerUpList[Random.Range(0, powerUpList.Count)];
            SpawnPowerUp(chosenPowerUp, spawnPosition);
            print("Selam");
            print(lastPos);
        }
        /* int chosenNumber;

        chosenNumber = Random.Range(0, 30);
        if (chosenNumber >= 0 && chosenNumber < powerUpList.Count)
        {
            Transform chosenPowerUp = powerUpList[chosenNumber];
            Vector3 spawnPosition = transformLevel.Find("powerUpPosition").position;
            SpawnPowerUp(chosenPowerUp, spawnPosition);
        }*/

    }
    private void SpawnPowerUp(Transform powerUp, Vector3 spawnPosition)
    {
        lastPos = spawnPosition;
        Instantiate(powerUp, spawnPosition, Quaternion.identity);

    }
}