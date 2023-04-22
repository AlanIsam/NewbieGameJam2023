using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControl : MonoBehaviour
{
    public GameObject virtualCamera;
    public GameObject Room;
    public GameObject[] enemies;
    public Vector3[] enemiesInitialPosition { get; set; }
  

    private void Start()
    {
        enemiesInitialPosition = new Vector3[enemies.Length];
        for(int i = 0; i < enemies.Length; i++)
        {
            enemiesInitialPosition[i] = enemies[i].transform.position;
        }
        
        for(int i = 0; i < Room.transform.childCount; i++)
        {
            Room.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            for(int i = 0; i < Room.transform.childCount; i++)
            {
                Room.transform.GetChild(i).gameObject.SetActive(true);
            }
            virtualCamera.SetActive(true);
            
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            for(int i = 0; i < Room.transform.childCount; i++)
            {
                Room.transform.GetChild(i).gameObject.SetActive(false);
            }
            virtualCamera.SetActive(false);
            
            for(int i = 0; i < enemies.Length; i++)
            {
                enemies[i].transform.position = enemiesInitialPosition[i];
            }

        }
    }
}
