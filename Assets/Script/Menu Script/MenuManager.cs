using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    public void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}