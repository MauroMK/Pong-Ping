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

    #endregion

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetPosition();
    }

    public void EnemyScores()
    {
        enemyScore++;
        enemyScoreText.text = enemyScore.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<Ball>().ResetPos();
        playerPaddle.GetComponent<PlayerControll>().ResetPos();
        enemyPaddle.GetComponent<PlayerControll>().ResetPos();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
