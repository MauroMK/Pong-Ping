using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private float fadeSpeed = 0.5f;

    public CanvasGroup MainMenuPanel;
    public CanvasGroup GameSelectionPanel;
    public CanvasGroup SettingsMenu;

    public void ToGameSelection()
    {
        HideMainMenu();
        Invoke("ShowGameSelection", 0.5f);
    }

    public void ToMainMenuFromGame()
    {
        HideGameSelection();
        Invoke("ShowMainMenu", 0.5f);
    }

    public void ToMainMenuFromSettings()
    {
        HideSettingsMenu();
        Invoke("ShowMainMenu", 0.5f);
    }

    public void ToSettingsMenu()
    {
        HideMainMenu();
        Invoke("ShowSettingsMenu", 0.5f);
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

    //* Settings Menu
    private void ShowSettingsMenu()
    {
        LeanTween.alphaCanvas(SettingsMenu, 1, fadeSpeed);
        SettingsMenu.interactable = true;
        SettingsMenu.blocksRaycasts = true;
    }

    private void HideSettingsMenu()
    {
        LeanTween.alphaCanvas(SettingsMenu, 0, fadeSpeed);
        SettingsMenu.interactable = false;
        SettingsMenu.blocksRaycasts = false;
    }
    
}
