﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public scoreUpdate scoreUpdate;
    public Health health;
    public bool isInvurnerable = false;

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
        yield return new WaitForSeconds(3f);
        isInvurnerable = false;
    }
}
