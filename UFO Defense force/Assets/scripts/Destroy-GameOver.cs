using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float TopBounds;
    public float LowBounds;
    public GameManager gameManager;

    void Start()
     {
         gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
     }

    void Update()
    {
        if (transform.position.z > TopBounds)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < LowBounds)
        {
            Debug.Log("Game Over, man!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }
        // destroys game objects, sets time scale to 0 if lower bounds
    }
}
