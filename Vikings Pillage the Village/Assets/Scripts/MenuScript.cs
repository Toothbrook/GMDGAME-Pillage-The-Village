using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Start game by switching to the game scene
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //Exit out of the application
    public void ExitGame()
    {
        Debug.Log("quitted");
        Application.Quit();
    }
}
