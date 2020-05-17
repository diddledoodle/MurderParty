using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsMenuPanel;
    public GameObject titleMenuPanel;

    private void Start()
    {
        creditsMenuPanel.SetActive(false);
        titleMenuPanel.SetActive(true);
        // Hide the mouse cursor
        Cursor.visible = false;
    }

    public void LoadGameScene(string _levelName)
    {
        SceneManager.LoadSceneAsync(_levelName);
    }
    public void ShowCredits()
    {
        creditsMenuPanel.SetActive(true);
        creditsMenuPanel.GetComponent<MenuNavigation>().SelectFirstIndexOnEnable();
    }
    public void ShowTitle()
    {
        titleMenuPanel.SetActive(true);
        titleMenuPanel.GetComponent<MenuNavigation>().SelectFirstIndexOnEnable();
    }
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    /*jpost audio*/
    //play start game sound
    public void PlayStartSound()
    {
        //plays the wwise event at the location of the second argument (gameObject)
        AkSoundEngine.PostEvent("play_bb_sx_menu_ui_main_start", gameObject);
        //fades out the main menu music if it is still playing
        AkSoundEngine.PostEvent("stop_bb_mx_menu", gameObject);
    }
}
