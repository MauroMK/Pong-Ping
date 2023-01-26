using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    
    private ScoreUIController UIController;    
    private Rigidbody2D ballRb;
    private PongGameManager pongManager;
    private PongMenuController pongMenuController;

    private Vector3 startPosition;

    void Awake()
    {
        UIController = FindObjectOfType<ScoreUIController>();
    }

    void Start()
    {
        pongMenuController = FindObjectOfType<PongMenuController>();
        pongManager = FindObjectOfType<PongGameManager>();
        ballRb = GetComponent<Rigidbody2D>();

        Launch();
    }

    public void Launch()
    {
        if (pongMenuController.isPaused == false)
        {
            float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
            float speedY = Random.Range(0, 2) == 0 ? -1 : 1;
            
            ballRb.velocity = new Vector3(speed * speedX, speed * speedY, 0f);
        }
        else
        {
            return;
        }

    }

    public void ResetPos()
    {
        ballRb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BottomWall"))
        {
            pongManager.EnemyScores();
            
            UIController.ShowPointsOnScreen();              // * Shows the points on the screen
            UIController.Invoke("HidePointsOnScreen", 2f);  // * After 2 seconds, calls the function to hide the score
        }

        if (other.gameObject.CompareTag("TopWall"))
        {
            pongManager.PlayerScores();

            UIController.ShowPointsOnScreen();              // * Shows the points on the screen
            UIController.Invoke("HidePointsOnScreen", 2f);  // * After 2 seconds, calls the function to hide the score
        }
    }
}
