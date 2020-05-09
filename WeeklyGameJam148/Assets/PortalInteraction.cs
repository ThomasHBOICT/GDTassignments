using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PortalInteraction : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject[] enemies;
    public Color dimentionColor;
    public Sprite coinSprite;
    public Sprite enemySprite;

    private bool isFlipped = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("portal entered.");
            ChangeMapColor();
            ChangeEnemies();
        }
    }

    private void ChangeEnemies()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        foreach (GameObject enemy in enemies)
        {
            if (enemy.GetComponent<SpriteRenderer>().sprite == coinSprite)
            {
                enemy.GetComponent<SpriteRenderer>().sprite = enemySprite;
                enemy.GetComponent<EnemyMovement>().enabled = true;
            }
            else
            {
                enemy.GetComponent<SpriteRenderer>().sprite = coinSprite;
                enemy.GetComponent<EnemyMovement>().enabled = false;
            }
        }        
    }

    private void ChangeMapColor()
    {
        isFlipped = !isFlipped;
        if (isFlipped)
        {
            tilemap.color = dimentionColor;
        }
        else
        {
            tilemap.color = new Color(0.75f, 1, 0.32f, 1);
        }
    }
}
