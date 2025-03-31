using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject[] obstaclePrefabs;

    //private Vector3 spawnPos = new Vector3(40, 0, 0);
    private float startDelay = 1;
    private float repeatRate = 1;

    private float spawnPosY = 5.26f;
    private float spawnPosZ = -8.2f;

    private float fastRepeatRate = 0.5f; // Velocidade maior quando score >= 15
    private bool isFastSpawning = false; // Para evitar reiniciar o spawn repetidamente


    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        if ( !isFastSpawning)
        {
            isFastSpawning = true; // Evita chamadas repetidas
            CancelInvoke("SpawnObstacle");
            InvokeRepeating("SpawnObstacle", 0f, fastRepeatRate);
        }
        

    }
    
    void SpawnObstacle()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(0.34f, spawnPosY, spawnPosZ);

        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos,
         obstaclePrefabs[obstacleIndex].transform.rotation);
       // }
    }
}
