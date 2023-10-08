using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    public GameObject tryAgainMenu;
    private bool isMenuShown = false;
    private PlayerHealth playerHealth;

    private void Start()
    {
        // Get a reference to the PlayerHealth component
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void Update()
    {
        // Check if the player's health is less than or equal to 0 and the menu is not shown
        if (playerHealth.playerHealth <= 0 && !isMenuShown)
        {
            ShowTryAgainMenu();
        }
    }

    private void ShowTryAgainMenu()
    {
        tryAgainMenu.SetActive(true);
        Time.timeScale = 0f; // Pause the game
        isMenuShown = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PlayerPrefs.DeleteAll();
    }

    public void TryAgain()
    {
        Cursor.visible = false;
        tryAgainMenu.SetActive(false);
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}