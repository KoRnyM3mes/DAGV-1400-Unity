using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public int sceneToLoad;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Load complete!");
    }
    public void QuitGameOver()
    {
        Application.Quit();
        Debug.Log("Quitting game.");
    }
}
