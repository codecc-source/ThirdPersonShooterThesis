using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeTrialScore : MonoBehaviour
{
    public static timeTrialScore instance;

    public TextMeshProUGUI ttScoreText;
    public TextMeshProUGUI maxScoreText;

    public static int ttscore;
    public static int maxTimeScore;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        maxTimeScore = PlayerPrefs.GetInt("maxTimeScore", 0);
        ttscore = PlayerPrefs.GetInt("ttscore", 0);

        if (ttScoreText != null)
        {
            ttScoreText.text = "SCORE: " + ttscore.ToString();
        }

        if (maxScoreText != null)
        {
            maxScoreText.text = "Time Trial Max Score: " + maxTimeScore.ToString();
        }
    }

    public void ttAddScore()
    {
        ttscore += 10;
        maxTimeScore = ttscore;

        if (ttScoreText != null)
        {
            ttScoreText.text = "SCORE: " + ttscore.ToString();
        }

        if (maxScoreText != null)
        {
            maxScoreText.text = "Time Trial Max Score: " + maxTimeScore.ToString();
        }

        PlayerPrefs.SetInt("ttscore", ttscore);
        PlayerPrefs.SetInt("maxTimeScore", maxTimeScore);
        PlayerPrefs.Save();
    }

    void OnApplicationQuit()
    {
        Debug.Log("UITTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTERTEWRWERHWEJKRHKH");
        PlayerPrefs.DeleteAll();
    }
}
