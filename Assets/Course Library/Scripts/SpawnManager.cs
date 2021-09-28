using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 20;
    private int spawnRangeZ = 20;
    private int spawnPosZ = 20;
    private int spawnPosX = 20;
    private float spawnDelay = 1f;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalHorizontal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosVertical = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosVertical, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalHorizontal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, Quaternion.Euler(0, -90, 0));
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPosLeft, Quaternion.Euler(0, 90, 0));
    }
}
