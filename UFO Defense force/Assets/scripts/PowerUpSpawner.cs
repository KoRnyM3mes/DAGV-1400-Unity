using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PowerUpSpawner : MonoBehaviour
{
    private float spawnRangeX = 20f;
    private float spawnPositionZ = 20f;
    public GameObject[] PowerupPrefabs; //array to store powerups

    private float startDelay = 10f;
    private float spawnInterval = 10f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomPowerup", startDelay, spawnInterval);
        //constantly spawns powerups
    }
    void SpawnRandomPowerup()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        //spawns powerup in a random location within the bounds of the game
        int PowerupIndex = Random.Range(0,PowerupPrefabs.Length);//picks random prefab in Powerups
        Instantiate(PowerupPrefabs[PowerupIndex], spawnPOs, PowerupPrefabs[PowerupIndex].transform.rotation);
        //instantiates a powerup from the array 
    }
}
