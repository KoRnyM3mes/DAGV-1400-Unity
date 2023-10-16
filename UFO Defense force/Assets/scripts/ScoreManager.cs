using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //uses TMPro extension in Unity

public class ScoreManager : MonoBehaviour
{
    public int score; //current score from player
    public TextMeshProUGUI scoreText; //what the player will see in game

    public void IncreaseScore(int amount) //increases score for player
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //decreases score for player
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Updates the score that the player will see
    {
        scoreText.text = "Score: " + score;
    }
}
