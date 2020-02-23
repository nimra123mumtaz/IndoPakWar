using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{

   
    public static bool PauseGame = false;
    public GameObject PauseMenuUI;
    public static bool gamequit = false;
    public GameObject quitgame;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pasue();
            }
        }

       
    }


    public void Resume()
    {

        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    void Pasue()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LoadMenu(string scenename)
    {
        Application.LoadLevel(scenename);
    }
    public void QuitGame()
    {
        quitgame.SetActive(false);
        Time.timeScale = 1f;
        gamequit = false;
    }
}
