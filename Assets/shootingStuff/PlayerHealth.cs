using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public TextMeshProUGUI playerHPText;
    public int playerMaxHealth = 100;

    void Start()
    {
        playerHealth = playerMaxHealth;
    }

    private void Update()
    {
        playerHPText.text = "HP: " + playerHealth;
    }


    public void playerTakeDamage(int playerDmgAmount)
    {
        playerHealth -= playerDmgAmount;
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddHealth(int amount)
    {
        playerHealth += playerMaxHealth;
        if (playerHealth > playerMaxHealth)
        {
            playerHealth = playerMaxHealth;
        }
    }
}
