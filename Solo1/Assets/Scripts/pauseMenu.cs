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
       if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button7) && paused == false)
        {
            Debug.Log("pause game");
            paused = true;
            UI.PauseGame();
        }
       else if((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button7) && paused == true))
        {
            Debug.Log("continue game");
            paused = false;
            UI.ContinueGame();
        }
    }
}
