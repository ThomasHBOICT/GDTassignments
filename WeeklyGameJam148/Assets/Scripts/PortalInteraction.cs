using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Pathfinding;


public class PortalInteraction : MonoBehaviour
{
    public Tilemap tilemap;
    public Panel panel;
    public GameObject[] enemies;
    public Sprite coinSprite;
    public Sprite enemySprite;

    public static bool isFlipped = false;

    private void Start()
    {
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        panel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Panel>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("portal entered.");
            ChangeMapColor();
            ChangeEnemies();
            EnableUIPanel();
        }
    }

    private void ChangeEnemies()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        foreach (GameObject enemy in enemies)
        {
            if (enemy.GetComponent<AIPath>().enabled == false)
            {
                // is coin now
                enemy.GetComponentInChildren<SpriteRenderer>().sprite = enemySprite;
                enemy.GetComponent<AIPath>().enabled = true;
                enemy.GetComponent<EnemyInteraction>().isCoin = false;
                enemy.GetComponent<Transform>().tag = "Enemy";
            }
            else
            {
                // is enemy now
                enemy.GetComponentInChildren<SpriteRenderer>().sprite = coinSprite;
                enemy.GetComponent<AIPath>().enabled = false;
                enemy.GetComponent<EnemyInteraction>().isCoin = true;
                enemy.GetComponent<Transform>().tag = "Coin";
            }
        }        
    }

    private void ChangeMapColor()
    {
        isFlipped = !isFlipped;
        if (isFlipped)
        {
            tilemap.color = new Color(0.55f, 0, 0, 1);
        }
        else
        {
            tilemap.color = new Color(0.75f, 1, 0.32f, 1);
        }
    }

    private void EnableUIPanel()
    {
        if (isFlipped)
        {
            panel.TogglePanel(true);
        }
        else
        {
            panel.TogglePanel(false);
        }
    }
}
