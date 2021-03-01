using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyShipPrefab;
    public float spawnRangeX = 20;
    public float spawnRangeZ = 20;
    public float spawnRangeY = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemyShip", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemyShip()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), spawnRangeZ);
      
        Instantiate(enemyShipPrefab, spawnPos, enemyShipPrefab.transform.rotation);
    }

}
