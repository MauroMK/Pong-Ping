using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void SceneLoader(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
