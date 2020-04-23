using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopInteraction : MonoBehaviour
{
    public gameController gameController;
    public playerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shopping();
    }

    public void Shopping()
    {
        if (gameController.shopOpen)
        {
            if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                if(playerHealth.health < playerHealth.numOfHearts)
                {
                    Debug.Log("life bought, nice");
                    gameController.LifeBought();
                }
                else
                {
                    Debug.Log("already max health. lol");
                }
            }
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                gameController.ShieldBought();
                Debug.Log("shield leveled up, nice");
            }

        }
    }
}
