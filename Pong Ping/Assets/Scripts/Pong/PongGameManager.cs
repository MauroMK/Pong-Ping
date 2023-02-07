using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class PongGameManager : MonoBehaviour
{
    #region Variables

    [Header("Game")]
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject playerPaddle;
    [SerializeField] private GameObject enemyPaddle;

    [Header("Scores")]
    public int playerScore;
    public int enemyScore;

    [Header("Text Score")]
    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;

    private int scoreToReach = 3;

    private PongMenuController menuController;

    #endregion

    void Start()
    {
        menuController = FindObjectOfType<PongMenuController>();
    }

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        CheckScore();
    }

    public void EnemyScores()
    {
        enemyScore++;
        enemyScoreText.text = enemyScore.ToString();
        CheckScore();
    }

    public void ResetPosition()
    {
        playerPaddle.GetComponent<PlayerControll>().ResetPos();
        enemyPaddle.GetComponent<PlayerControll>().ResetPos();
    }

    private void CheckScore()
    {
        if (playerScore == scoreToReach || enemyScore == scoreToReach)
        {
            menuController.ShowGameOver();
        }
    }
}
