using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;

    public static GameController instance;

    void Start()
    {
        instance = this;
    }

    public void UpdateScore(int score)
    {
        totalScore += score;

        if (totalScore < 10)
        {
            scoreText.text = "0" + totalScore.ToString();
        }
        else
        {
            scoreText.text = totalScore.ToString();
        }
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
