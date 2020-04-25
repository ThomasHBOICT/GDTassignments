using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontrol : MonoBehaviour
{
    public GameObject onDeathMenu;
    //public GameObject shopMenu;
    public GameObject pauseMenu;
    //public GameObject settingsMenu;
   

    public void PlayGame()
    {
        onDeathMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void PlayerDied()
    {
        onDeathMenu.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    /*
    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    

    public void QuitGame()
    {
        Debug.Log("quitgame");
    }

    public void OpenShop()
    {
        shopMenu.SetActive(true);
    }

    public void CloseShop()
    {
        shopMenu.SetActive(false);
    }*/
}
