using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbPathfinding : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float lineOfSight;
    private Transform player;
    private bool isFacingRight = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceFromPlayer < lineOfSight)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);


            //flip the enemy when its facing player
            if (isFacingRight && player.position.x < transform.position.x ||
                !isFacingRight && player.position.x > transform.position.x)
            {
                Flip();
            }


        }
        

        void Flip()
        {
            isFacingRight = !isFacingRight;
            Vector3 tmpScale = gameObject.transform.localScale;
            tmpScale.x *= -1;
            gameObject.transform.localScale = tmpScale;
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lineOfSight);
    }
}