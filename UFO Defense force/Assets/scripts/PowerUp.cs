using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        pickup();
    }

    void pickup()
    {
        Debug.Log("PowerUp Obtained!");
    }
}
