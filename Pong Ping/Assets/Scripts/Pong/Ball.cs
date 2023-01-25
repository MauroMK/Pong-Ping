using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Rigidbody2D ballRb;

    private PongGameManager pongManager;

    void Start()
    {
        pongManager = FindObjectOfType<PongGameManager>();

        ballRb = GetComponent<Rigidbody2D>();

        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        ballRb.velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BottomWall"))
        {
            pongManager.enemyScore++;
            pongManager.enemyScoreText.text = pongManager.enemyScore.ToString();
        }

        if (other.gameObject.CompareTag("TopWall"))
        {
            pongManager.playerScore++;
            pongManager.playerScoreText.text = pongManager.playerScore.ToString();
        }
    }
}
