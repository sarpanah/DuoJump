using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject boxPrefab;

    public int numberOfPlatforms;

    void Start()
    {
        Vector3 spawnPos = new Vector3();
        
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPos.x += Random.Range(10f, 20f);
            spawnPos.y = -3.75f;
            Instantiate(boxPrefab, spawnPos, Quaternion.identity);
            Debug.Log(spawnPos);
        }        
    }

}
