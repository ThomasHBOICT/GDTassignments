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

    public static bool isFlipped = false;

    private void Start()
    {
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
    }
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
                enemy.GetComponent<EnemyInteraction>().isCoin = false;
            }
            else
            {
                enemy.GetComponent<SpriteRenderer>().sprite = coinSprite;
                enemy.GetComponent<EnemyMovement>().enabled = false;
                enemy.GetComponent<EnemyInteraction>().isCoin = true;
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
