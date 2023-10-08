using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoringScript : MonoBehaviour
{
    public static ScoringScript instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI LevelIndicator;

    public static int timesReloaded;
    public static int score;
    public static int scoreThreshold = 50;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "SCORE: " + score.ToString();
        LevelIndicator.text = "Level: " + timesReloaded.ToString();
    }

    public void AddScore()
    {
        score += 10;
        scoreText.text = "SCORE: " + score.ToString();
        if (score >= scoreThreshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.Save();
            scoreThreshold += 50;
        }
    }

    void OnApplicationQuit()
    {
        Debug.Log("UITTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTERTEWRWERHWEJKRHKH");
        PlayerPrefs.DeleteAll();
    }
}
