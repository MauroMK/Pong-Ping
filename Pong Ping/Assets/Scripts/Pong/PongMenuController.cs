using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongMenuController : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pauseButton;

    public bool isPaused;

    private Ball ballScript;

    void Start()
    {
        ballScript = FindObjectOfType<Ball>();
    }

    public void ShowPauseMenu()
    {
        isPaused = true;
        Time.timeScale = 0;
        /* LeanTween.alphaCanvas(pausePanel, 1, 1f);
        pausePanel.interactable = true;
        pausePanel.blocksRaycasts = true; */
        pauseButton.SetActive(false);
        pausePanel.SetActive(true);
    }

    public void HidePauseMenu()
    {
        isPaused = false;
        Time.timeScale = 1;
        /* LeanTween.alphaCanvas(pausePanel, 0, 1f);
        pausePanel.interactable = false;
        pausePanel.blocksRaycasts = false;
        ballScript.Launch(); */
        pauseButton.SetActive(true);
        pausePanel.SetActive(false);
    }
}
