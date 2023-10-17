using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    public void Start()
    {
        gameOverText = GameObject.Find("GameOverText");//finds the game over text
    }
    void Update()
    {
        if (isGameOver)
        {
            EndGame(); 
        }
        else
        {
            gameOverText.gameObject.SetActive(false); //disables the game over text at the top
        }
    }
    private void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //enables text
        Time.timeScale = 0; //freezes time, game over man!
    }
}
