using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Declares stuff for text ui
    private int score;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }

    // Method to set game over, REMOVE IF IT DOESNT WORK
    public void GameOver()
    {
        gameOverUI.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to update score
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreUI.text = "Score: " + score;
    }
}
