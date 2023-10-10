using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float TopBounds;
    public float LowBounds;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
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
            Time.timeScale = 0;
        }
        // destroys game objects
    }
}
