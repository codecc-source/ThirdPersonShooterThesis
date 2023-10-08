using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public string sceneToLoad = "timeTrial";
    //Start Game
    public void Play()
    {
        ScoringScript.timesReloaded = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.DeleteAll();
    }

    public void TimeTr()
    {
        Cursor.lockState = CursorLockMode.Locked; // Hide and lock the cursor
        Cursor.visible = false;
        SceneManager.LoadScene(sceneToLoad);
        PlayerPrefs.DeleteAll();
    }

    //Exit game
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Player has exited the game");
        PlayerPrefs.DeleteAll();
    }
}
