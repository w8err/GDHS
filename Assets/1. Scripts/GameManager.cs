using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public static GameManager instance = null;
    private int score = 0;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score : " + score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
