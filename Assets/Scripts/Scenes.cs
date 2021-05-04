using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void nextButton()
    {
        SceneManager.LoadScene(1);
       
    }

    public void donePlaying()
    {
        SceneManager.LoadScene(2);
    }

    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
