using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class addVignette : MonoBehaviour
{
    public Image healthImage;
    public int healthThreshold = 20;
    public TextMeshProUGUI amhurtText;

    void Update()
    {
        int currentHealth = GetComponent<PlayerHealth>().playerHealth;

        if (currentHealth < healthThreshold)
        {
            healthImage.enabled = true;
            amhurtText.enabled = true;
        }
        else
        {
            healthImage.enabled = false;
            amhurtText.enabled = false;
        }
    }
}