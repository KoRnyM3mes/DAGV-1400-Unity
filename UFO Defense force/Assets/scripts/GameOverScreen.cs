using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public int sceneToLoad;
    public void RestartGame()
    {
        FindObjectOfType<AudioManager>().Play("MenuPlay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("MenuQuit");
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Load complete!");
    }
    public void QuitGameOver()
    {
        FindObjectOfType<AudioManager>().Play("MenuQuit");
        Debug.Log("Quitting game.");
        Application.Quit();
    }
}
