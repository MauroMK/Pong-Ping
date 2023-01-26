using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private float fadeSpeed = 0.5f;

    public CanvasGroup MainMenuPanel;
    public CanvasGroup GameSelectionPanel;

    public void ToTheGameSelection()
    {
        HideMainMenu();
        Invoke("ShowGameSelection", 1);
    }

    public void ToTheMainMenu()
    {
        HideGameSelection();
        Invoke("ShowMainMenu", 1f);
    }

    //* Main Menu
    private void ShowMainMenu()
    {
        LeanTween.alphaCanvas(MainMenuPanel, 1, fadeSpeed);
        MainMenuPanel.interactable = true;
        MainMenuPanel.blocksRaycasts = true;
    }

    private void HideMainMenu()
    {
        LeanTween.alphaCanvas(MainMenuPanel, 0, fadeSpeed);
        MainMenuPanel.interactable = false;
        MainMenuPanel.blocksRaycasts = false;
    }

    //* Game Selection
    private void ShowGameSelection()
    {
        LeanTween.alphaCanvas(GameSelectionPanel, 1, fadeSpeed);
        GameSelectionPanel.interactable = true;
        GameSelectionPanel.blocksRaycasts = true;
    }

    private void HideGameSelection()
    {
        LeanTween.alphaCanvas(GameSelectionPanel, 0, fadeSpeed);
        GameSelectionPanel.interactable = false;
        GameSelectionPanel.blocksRaycasts = false;
    }
    
}
