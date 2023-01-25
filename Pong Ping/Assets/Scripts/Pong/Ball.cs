using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Rigidbody2D ballRb;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();

        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        ballRb.velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BottomWall"))
        {
           //TODO: point to the enemy through some future function in PongGameManager script
            Debug.Log("Enemy scored 1 point");
        }

        if (other.gameObject.CompareTag("TopWall"))
        {
           //TODO: point to you through some future function in PongGameManager script
            Debug.Log("You scored 1 point");
        }
    }
}
