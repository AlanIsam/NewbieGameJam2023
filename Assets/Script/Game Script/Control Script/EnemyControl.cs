using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3[] enemiesInitialPosition { get; set; }
 
    // Use this for initialization
    void Start () {
        enemiesInitialPosition = new Vector3[enemies.Length];
        for(int i = 0; i < enemies.Length; i++)
        {
            enemiesInitialPosition[i] = enemies[i].transform.position;
        }
    }
}