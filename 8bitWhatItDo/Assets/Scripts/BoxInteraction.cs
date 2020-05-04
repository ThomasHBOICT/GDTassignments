using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    public PlayerInteraction playerInteraction;
    public GameObject Item;
    public GameObject Hat;
    private bool inRange = false;

    public enum Pickups { Hat, Item, Nothing };

    public Pickups toDrop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pickup();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = false;
        }
    }

    private void Pickup()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange && toDrop == Pickups.Item)
        {
            playerInteraction.HandPickup(Item);
        }
        else if (Input.GetKeyDown(KeyCode.E) && inRange && toDrop == Pickups.Hat)
        {
            playerInteraction.HeadPickup(Hat);
        }
        else if (Input.GetKeyDown(KeyCode.E) && inRange && toDrop == Pickups.Nothing)
        {
        }
    }
}
