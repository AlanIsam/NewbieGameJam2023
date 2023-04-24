using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontalpatrol : MonoBehaviour
{
    private void Update()
    {
        //check if enemy is moving left and right
        if (_movingLeft)
        {
            if(enemy.position.x >= leftPoint.position.x)
            {
                MoveInDirection(-1);
            }
            else
            {
                DirectionChange();

            }
        }
        else
        {
            if (enemy.position.x <= rightPoint.position.x)
            {
                MoveInDirection(1);
            }
            else
            {
                DirectionChange();

            }
        }
    }

    //direction change method
    private void DirectionChange()
    {
        _movingLeft = !_movingLeft;
    }

    [Header("Patrol Points")]
    [SerializeField] private Transform leftPoint;
    [SerializeField] private Transform rightPoint;

    [Header("Enemy")]
    [SerializeField] private Transform enemy;

    [Header("Movement")]
    [SerializeField] private float speed;
    private Vector3 _initScale;
    private bool _movingLeft;

    private void Awake()
    {
        _initScale = enemy.localScale;
    }

    //move in direction method
    private void MoveInDirection (int direction)
    {
        //make enemy face direction
        enemy.localScale = new Vector3(Mathf.Abs(_initScale.x) * direction, _initScale.y, _initScale.z);

        //move in that directions
        var position = enemy.position;
        position = new Vector3(position.x + direction * speed * Time.deltaTime, position.y, position.z);
        enemy.position = position;
    }
    }
