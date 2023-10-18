using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;
    private GameObject retryButton;
    private GameObject mainMenuButton;
    private GameObject quitButton;
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    public void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        retryButton = GameObject.Find("RetryButton");
        mainMenuButton = GameObject.Find("MainMenuButton");
        quitButton = GameObject.Find("QuitButton");
        //Finds all the components of the game over screen
    }
    void Update()
    {
        if (isGameOver)
        {
            EndGame(); 
        }
        else
        {
            gameOverText.gameObject.SetActive(false); 
            retryButton.gameObject.SetActive(false);
            mainMenuButton.gameObject.SetActive(false);
            quitButton.gameObject.SetActive(false);
            //Disables the entire game over screen
        }
    }
    private void EndGame()
    {
        FindObjectOfType<AudioManager>().Play("GameOver");
        gameOverText.gameObject.SetActive(true); //enables text
        retryButton.gameObject.SetActive(true);
        mainMenuButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        Time.timeScale = 0; //freezes time, game over man!
    }
}
