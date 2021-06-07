using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtLineGen : MonoBehaviour
{
    [SerializeField] private Transform externalPart_Start;

    [SerializeField] private Transform externalPart;

    [SerializeField] private GameObject camera;
    private const float aPLAYER_DISTANCE_SPAWN_LEVEL_PART = 100f;
    private Vector3 lastEndingPoint;
    private List<Transform> createdexternalList;
    Transform tempLevel = null;
    private void Awake()
    {
        createdexternalList = new List<Transform>();
        lastEndingPoint = externalPart_Start.Find("EndingPoint").position;
        /*int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            ExternalLevelPart();
        }*/


    }
    private void Update()
    {
        if (Vector3.Distance(camera.transform.position, lastEndingPoint) < aPLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            ExternalLevelPart();
        }
        
            foreach (var level in createdexternalList)
            {
                if (level.gameObject.active)
                {
                    if (level.position.y > camera.transform.position.y)
                    {
                        if (Vector3.Distance(camera.transform.position, level.transform.position) > 600f)
                        {
                            level.gameObject.SetActive(false);
                        }
                    }
                }
                if (!level.gameObject.active)
                {
                    if (level.position.y > camera.transform.position.y)
                    {
                        if (Vector3.Distance(camera.transform.position, level.transform.position) < 200f)
                        {
                            level.gameObject.SetActive(true);
                        }
                    }
                }
            
        }





    }
    private void ExternalLevelPart()
    {
        
        
        
        Transform lastExternalPartTransform = ExternalLevelPart(externalPart, lastEndingPoint);
        lastEndingPoint = lastExternalPartTransform.Find("EndingPoint").position;
    }
    private Transform ExternalLevelPart(Transform externalPart, Vector3 spawnPosition)
    {
        Transform externalPartTransform = Instantiate(externalPart, spawnPosition, Quaternion.identity);
        createdexternalList.Add(externalPartTransform);
        return externalPartTransform;
    }





}
