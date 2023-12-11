using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Declares stuff for text ui
    private int score;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI gameOverUI;
    public Button restartButton;

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
        restartButton.gameObject.SetActive(true);
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

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
