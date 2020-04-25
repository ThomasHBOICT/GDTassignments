using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInteraction : MonoBehaviour
{
    //public soundController sound;
    public gameController controller;
    public playerHealth health;
    public UIcontrol UI;
   // public cameraShake Camera;

    public bool isInvurnerable = false;
    
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            Debug.Log("coin picked up");
            controller.CoinPickup();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            if (isInvurnerable == false && health.health > 1)
            {
                //Camera.camShake();
                Debug.Log("damaged");
                // lose health
                health.loseHealth();
                StartCoroutine("Invurnerable");
                //sound.SoundHit();
            }
            else if (isInvurnerable == false && health.health == 1)
            {
               // sound.SoundHit();
                health.loseHealth();
                EndGame();
            }
        }
    }

    IEnumerator Invurnerable()
    {
        MeshRenderer m = gameObject.GetComponent<MeshRenderer>();
        isInvurnerable = true;
       /* for (int i = 0; i < 3; i++)
        {
            m.enabled = false;
            yield return new WaitForSeconds(0.25f);
            m.enabled = true;
            yield return new WaitForSeconds(0.25f);
            m.enabled = false;
            yield return new WaitForSeconds(0.25f);
            m.enabled = true;
            yield return new WaitForSeconds(0.25f);
        }*/
        yield return new WaitForSeconds(3f);
        isInvurnerable = false;
    }

    private void EndGame()
    {
        Debug.Log("u died");
        UI.PlayerDied();
    }
}
