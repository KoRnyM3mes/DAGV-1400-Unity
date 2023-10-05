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
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Debug.Log("PowerUp Obtained!");

        PlayerController stats = player.GetComponent<PlayerController>();
        stats.speed *= multiplier;
        
        Destroy(gameObject);
    }
}
