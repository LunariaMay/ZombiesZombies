using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zombiePrefabs;

    // Random spawn times and specified spawn times
    private float spawnRangeX = 7;
    private float spawnRangeY = 3f;
    private float startDelay = 2;
    private float spawnInterval = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomZombie", startDelay, spawnInterval);
    }

    void SpawnRandomZombie()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Instantiate(zombiePrefabs[zombieIndex], spawnPos, zombiePrefabs[zombieIndex].transform.rotation);
        // Thanks to a fellow student for helping me get the random spawn range to work lol
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
