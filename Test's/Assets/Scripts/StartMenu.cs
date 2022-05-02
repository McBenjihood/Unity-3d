using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting Game ...");
        Application.Quit();
    }

    public void StartGame()
    {
        Debug.Log("Starting Game ...");
        SceneManager.LoadScene("Level 3");
        PauseMenu.GameIsPaused = false;

    }

}
