using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    

    public GameObject pauseMenuUI;
    public GameObject inGameUI;
    public GameObject timeManager;

    // Update is called once per frame

    void Start()
    {
        pauseMenuUI.SetActive(false);
        inGameUI.SetActive(true);
        timeManager.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        inGameUI.SetActive(true);
        timeManager.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        timeManager.SetActive(false);
        inGameUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        

    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }
    
}
