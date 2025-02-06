using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    public GameObject[] animalPrefabs3;
    private float spawnRangeX = 50;
    private float spawnPosZ = -65;
    private float startDelay = 0;
    private float spawnInterval;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(0.5f, 1.5f);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal() {
        // Randomly generate animal index and spawn position
        if (gameManager.isGameActive) { 
            Vector3 spawnPos = new Vector3(spawnRangeX, 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs3.Length);
            Instantiate(animalPrefabs3[animalIndex], spawnPos,
            animalPrefabs3[animalIndex].transform.rotation);
        }
        
    }
}
