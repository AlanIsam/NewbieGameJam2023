using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool timerOn = false;
    [SerializeField] float timeLeft;
    public GameObject winScreen;
    public GameObject player;

    void Start()
    {
        timerOn= true;
    }

    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerOn = false;
                timerText.color = Color.red;
                winScreen.SetActive(true);
                player.SetActive(false);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
    
}
