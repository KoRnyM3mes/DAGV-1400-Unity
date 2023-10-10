using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20f;
    private float spawnPositionZ = 20f;
    public GameObject[] ufoPrefabs; //array to store ufo ships

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUfo", startDelay, spawnInterval);
        //constantly spawns UFOs
    }
    void SpawnRandomUfo()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        //spawns UFO in a random location within the bounds of the game
        int ufoIndex = Random.Range(0,ufoPrefabs.Length);//picks random prefab in UFOs
        Instantiate(ufoPrefabs[ufoIndex], spawnPOs, ufoPrefabs[ufoIndex].transform.rotation);
        //instantiates a UFO from the array 
    }
}
