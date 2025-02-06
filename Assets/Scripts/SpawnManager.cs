using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    private float spawnRangeX = 20;
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
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
        }
            
    }
}