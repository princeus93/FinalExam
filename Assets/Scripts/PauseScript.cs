using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public static bool gameIsPaused;
    //public PlayerData pd;
    public GameObject pauseMenuUI;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    public void ResumeGame()
    {

        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        gameIsPaused = false;

    }
    void PauseGame()
    {

        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        gameIsPaused = true;

    }
}
