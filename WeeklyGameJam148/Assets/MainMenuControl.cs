using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuControl : MonoBehaviour
{
    public GameObject homePanel;
    public GameObject controlsPanel;
    public GameObject player;
    public GameObject arrow;
    public void GoToControls()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        homePanel.SetActive(false);
        controlsPanel.SetActive(true);
        player.SetActive(true);
        arrow.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
