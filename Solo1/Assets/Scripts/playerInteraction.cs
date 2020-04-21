using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInteraction : MonoBehaviour
{
    public gameController controller;
    public playerHealth health;
    public UIcontrol UI;
    public cameraShake Camera;

    public bool isInvurnerable = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Debug.Log("coin picked up");
            controller.CoinPickup();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            
            if (isInvurnerable == false && health.health > 1)
            {
                Camera.camShake();
                Debug.Log("damaged");
                // lose health
                health.loseHealth();
                StartCoroutine("Invurnerable");
            }
            else if (isInvurnerable == false && health.health == 1)
            {
                
                health.loseHealth();
                EndGame();
            }
            
        }
    }

    IEnumerator Invurnerable()
    {
        isInvurnerable = true;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        isInvurnerable = false;
        
    }

    private void EndGame()
    {
        Debug.Log("u died");
        UI.PauseGame();
    }
}
