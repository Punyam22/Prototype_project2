using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables
    public GameObject[] animalPrefabs;
    private float spawnRangeX= 20.0f;
    private float spawnPosZ= 20.0f;
    private int startDelay= 2;
    private float spawnInterval= 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn random animals
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal() 
    {
        int animalIndex= Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos= new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos , animalPrefabs[animalIndex].transform.rotation);
    }
    
}