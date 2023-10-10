using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float moveSpeed = 3f;
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime); //Moves powerup down screen
    }
}
