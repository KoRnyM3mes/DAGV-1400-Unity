using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store ufo ships
    public int ufoIndex;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 20), ufoPrefabs[ufoIndex].transform.rotation);
        }
    }
}
