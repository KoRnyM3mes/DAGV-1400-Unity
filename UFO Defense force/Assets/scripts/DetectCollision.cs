using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      Destroy(other.gameObject);
      Destroy(gameObject); //destroys both objects on collision 
   }
}
