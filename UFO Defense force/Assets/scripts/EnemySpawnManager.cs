using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20f;
    private float spawnPositionZ = 20f;
    public GameObject[] ufoPrefabs; //array to store ufo ships
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
            //spawns UFO in a random location within the bounds of the game
            int ufoIndex = Random.Range(0,ufoPrefabs.Length);//picks random prefab in UFOs
            Instantiate(ufoPrefabs[ufoIndex], spawnPOs, ufoPrefabs[ufoIndex].transform.rotation);
            //instantiates a UFO from the array
        }
    }
}
