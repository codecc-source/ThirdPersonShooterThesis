using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class maxTimeScoreScript : MonoBehaviour
{
    public TextMeshProUGUI maxScoreText;

    private void Start()
    {
        int maxTimeScore = PlayerPrefs.GetInt("maxTimeScore", 0);
        maxScoreText.text = "Max Time Trial Score: " + maxTimeScore.ToString();
    }
}
