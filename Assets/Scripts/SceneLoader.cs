using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene(string _levelName)
    {
        DialogueManager.StopConversation();
        SceneManager.LoadSceneAsync(_levelName);
    }
}
