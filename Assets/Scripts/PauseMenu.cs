using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public PistolShooterController pistolScript;
    public RifleShooterController rifleScript;
    public AudioSource pauseEffect;
    public AudioSource pauseBG;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            pauseEffect.Play();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        pistolScript.enabled = true; // Enable shooting script
        rifleScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked; // Hide and lock the cursor
        Cursor.visible = false;
        pauseBG.Play();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        pistolScript.enabled = false; // Disable shooting script
        rifleScript.enabled = false;
        pauseBG.Pause();
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        ScoringScript.timesReloaded = 1;
        SceneManager.LoadScene("MainMenu");
    }
}