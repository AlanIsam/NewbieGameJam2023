using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
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
}