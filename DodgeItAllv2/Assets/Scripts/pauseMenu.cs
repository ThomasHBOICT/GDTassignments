using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public UIcontrol UI;

    private bool paused = false;

    // Update is called once per frame
    void Update()
    {
        PauseGameMenu();
    }

    private void PauseGameMenu()
    {
       if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            if (paused)
            {
                Debug.Log("continue game");
                paused = false;
                UI.ContinueGame();
            }else
            {
                Debug.Log("pause game");
                paused = true;
                UI.PauseGame();
            }
        }
    }
}
