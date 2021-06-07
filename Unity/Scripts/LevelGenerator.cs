using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_Start;
    
    [SerializeField] private List<Transform> levelPartList;
    
    [SerializeField] private GameObject cam;
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 100f;
    private Vector3 lastEndPosition;
    private List<Transform> createdLevelList;
    Transform tempLevel = null;
    private void Awake()
    {
        createdLevelList = new List<Transform>();
        lastEndPosition = levelPart_Start.Find("EndPosition").position;
        int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
        
        
    }
    private void Update()
    {
        if(Vector3.Distance(cam.transform.position,lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
        foreach (var level in createdLevelList)
        {
            if (level.gameObject.active) {
                if (level.position.y > cam.transform.position.y)
                {
                    if (Vector3.Distance(cam.transform.position, level.transform.position) > 100f)
                    {
                        level.gameObject.SetActive(false);
                    }
                }
            }
            if (!level.gameObject.active) {
                if (level.position.y > cam.transform.position.y)
                {
                    if (Vector3.Distance(cam.transform.position, level.transform.position) < 70f)
                    {
                        level.gameObject.SetActive(true);
                    }
                }
            }
        }
        
        



    }
    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        if (tempLevel != null)
        {
            while (tempLevel.name == chosenLevelPart.name)
            {
                chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
            }
        }
        tempLevel = chosenLevelPart;
        Transform lastlLevelPartTransform = SpawnLevelPart(chosenLevelPart,lastEndPosition);
        lastEndPosition = lastlLevelPartTransform.Find("EndPosition").position;
    }
    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {       
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);        
        createdLevelList.Add(levelPartTransform);
        return levelPartTransform;
    }





}
