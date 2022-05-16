using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    [SerializeField] GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("works");
            if (GameIsPaused)
            {
                
                Resume();
            }
            else
            {
              
                Pause();
            }

        }

        if (Input.GetKeyDown(KeyCode.M) && GameIsPaused == true)
        {
            LoadMenu();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Resume()
    {
        Debug.Log("Resumed");
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
