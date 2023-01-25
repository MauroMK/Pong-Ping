using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private ScoreUIController UIController;

    [SerializeField] private float speed = 5f;
    
    private Rigidbody2D ballRb;
    private PongGameManager pongManager;

    void Awake()
    {
        UIController = FindObjectOfType<ScoreUIController>();
    }

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
            EnemyScores();
            
            UIController.ShowPointsOnScreen();              // * Shows the points on the screen
            UIController.Invoke("HidePointsOnScreen", 2f);  // * After 2 seconds, calls the function to hide the score
        }

        if (other.gameObject.CompareTag("TopWall"))
        {
            PlayerScores();

            UIController.ShowPointsOnScreen();              // * Shows the points on the screen
            UIController.Invoke("HidePointsOnScreen", 2f);  // * After 2 seconds, calls the function to hide the score
        }
    }

    public void PlayerScores()
    {
        pongManager.playerScore++;
        pongManager.playerScoreText.text = pongManager.playerScore.ToString();
    }

    public void EnemyScores()
    {
        pongManager.enemyScore++;
        pongManager.enemyScoreText.text = pongManager.enemyScore.ToString();
    }
}
