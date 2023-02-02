using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private PongGameManager gameManager;
    private BallMovement ballMovement;

    void Start()
    {
        gameManager = FindObjectOfType<PongGameManager>();
        ballMovement = FindObjectOfType<BallMovement>();
    }

    private void Bounce(Collision2D other)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = other.transform.position;

        float racketHeight = other.collider.bounds.size.x;
        float positionY;

        if (other.gameObject.CompareTag("Player"))
        {
            positionY = 1;
        }
        else
        {
            positionY = -1;
        }

        float positionX = (ballPosition.x - racketPosition.x) / racketHeight;
    
        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Enemy")
        {
            Bounce(other);
        }

        else if (other.gameObject.CompareTag("BottomWall"))
        {
            gameManager.EnemyScores();
            ballMovement.player1Start = true;           //* Verifies who starts the new round
            StartCoroutine(ballMovement.LaunchBall());  //* Starts the coroutine to restart the ball position and then throw her again
            gameManager.ResetPosition();                //* Resets the position of the players
        }

        else if (other.gameObject.CompareTag("TopWall"))
        {
            gameManager.PlayerScores();
            ballMovement.player1Start = false;          //* Verifies who starts the new round
            StartCoroutine(ballMovement.LaunchBall());  //* Starts the coroutine to restart the ball position and then throw her again
            gameManager.ResetPosition();                //* Resets the position of the players
        }
    }
}

