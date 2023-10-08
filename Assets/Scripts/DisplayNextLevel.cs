using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayNextLevel : MonoBehaviour
{
    public TextMeshProUGUI nextLevelText;
    public float displayTime = 5.0f;

    void Start()
    {
        StartCoroutine(ShowNextLevelText());
    }

    IEnumerator ShowNextLevelText()
    {
        nextLevelText.enabled = true;

        yield return new WaitForSeconds(displayTime);

        nextLevelText.enabled = false;
    }
}
