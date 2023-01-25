using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    private CanvasGroup CanvasGroup;
    private float fadeSpeed = 0.3f;

    void Start()
    {
        CanvasGroup = GetComponent<CanvasGroup>();
        CanvasGroup.alpha = 0;
    }

    public void ShowPointsOnScreen()
    {
        LeanTween.alphaCanvas(CanvasGroup, 1, fadeSpeed);
    }

    public void HidePointsOnScreen()
    {
        LeanTween.alphaCanvas(CanvasGroup, 0, fadeSpeed);
    }
}
