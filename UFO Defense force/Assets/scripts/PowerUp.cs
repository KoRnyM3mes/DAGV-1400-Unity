using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float multiplier = 1.5f;
    private float moveSpeed = 3.5f;
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime); //Moves powerup down screen
    }

    private void OnTriggerEnter(Collider other) //collider for power up
    {
        if (other.CompareTag("Player"))//checks if game object has player tag, so only player can pick it up
        {
            Pickup(other); //runs the pickup script
        }
    }

    void Pickup(Collider player) //passes the other variable into this function
    {
        Debug.Log("PowerUp Obtained!"); //log message for power up pickup

        PlayerController stats = player.GetComponent<PlayerController>(); //gets speed component from player controller script
        stats.speed *= multiplier; // applies the speed boost (perma rn)
        
        Destroy(gameObject);  //destroys the powerup capsule 
    }
}
