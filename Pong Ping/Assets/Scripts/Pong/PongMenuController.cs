using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongMenuController : MonoBehaviour
{
    public CanvasGroup pausePanel;
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
        LeanTween.alphaCanvas(pausePanel, 1, 1f);
        pausePanel.interactable = true;
        pausePanel.blocksRaycasts = true;
        pauseButton.SetActive(false);
    }

    public void HidePauseMenu()
    {
        isPaused = false;
        LeanTween.alphaCanvas(pausePanel, 0, 1f);
        pausePanel.interactable = false;
        pausePanel.blocksRaycasts = false;
        pauseButton.SetActive(true);
        ballScript.Launch();
    }
}
