﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private string gameSceneName;

    public void LoadGameScene()
    {
        SceneManager.LoadSceneAsync(gameSceneName);
    }
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

