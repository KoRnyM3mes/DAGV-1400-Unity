using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

   public ScoreManager scoreManager; //reference to ScoreManager script
   public int scoreToGive = 25;

   private void Start()
   {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find the Score Manager game object and refer score manager script
   }

   private void OnTriggerEnter(Collider other)
   {
      FindObjectOfType<AudioManager>().Play("UFODeath");
      scoreManager.IncreaseScore(scoreToGive); //increases score
      Destroy(other.gameObject);
      Destroy(gameObject); //destroys both objects on collision 
   }
}
