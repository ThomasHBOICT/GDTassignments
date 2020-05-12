using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public scoreUpdate scoreUpdate;
    public Health health;
    public bool isInvurnerable = false;
    private Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyInteraction enemyScript = collision.GetComponent<EnemyInteraction>();
        
        
        if (collision.tag == "Enemy")
        {
            if(enemyScript.isCoin == true)
            {
                scoreUpdate.ScoreUpdate(10);
            }else if(enemyScript.isCoin == false && isInvurnerable == false)
            {

                StartCoroutine("Rebirth");
                Debug.Log("player damaged, ouchies");
                health.currentHealth -= 1;
                health.HealthUpdate();
            }
        }
    }

    IEnumerator Rebirth()
    {
        isInvurnerable = true;
        for (int i = 0; i < 6; i++)
        {
            render.enabled = false;
            yield return new WaitForSeconds(0.25f);
            render.enabled = true;
            yield return new WaitForSeconds(0.25f);
        }
        isInvurnerable = false;
    }
}
