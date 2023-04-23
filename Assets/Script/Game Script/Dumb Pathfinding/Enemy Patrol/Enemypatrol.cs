using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypatrol : MonoBehaviour
{
    public float speed = 0.8f;
    public float range = 3;

    private float startingY;
    int dir = 1;

    void Start()
    {
        startingY= transform.position.y;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime *dir);
        if (transform.position.y < startingY || transform.position.y > startingY + range)
        {
            dir *= -1;
        }
    }
}
