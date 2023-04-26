using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    [SerializeField]  GameObject pauseMenu;
    [SerializeField]  GameObject guideMenu;
    public AudioSource buttonClick;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1f)
            {
                Pause();
            }
            else
            {
                Resume();

            }
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        buttonClick.Play();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        guideMenu.SetActive(false);
        Time.timeScale = 1f;
        buttonClick.Play();
    }
    
    public void Guide()
    {
        guideMenu.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 0f;
        buttonClick.Play();
    }
    
    public void Home(string sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        buttonClick.Play();
    }
    
}
