using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject Item;
    public Transform hand;
    public Transform head;

    public static bool hasItem = false;
    private ItemPickup ItemPickup;

    void Update()
    {
        PressE();
        PressQ(); ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item" && hasItem == false)
        {
            ItemPickup = collision.GetComponent<ItemPickup>();            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Item" && hasItem == false)
        {
            Debug.Log("collision exit");
            ItemPickup = null;
        }
    }

    private void PressE()
    {
        //Debug.Log(ItemPickup);
        if (Input.GetKeyDown(KeyCode.E) && ItemPickup != null && hasItem == false)
        {
            Debug.Log("i did press e, nerd");
            ItemPickup.Pickup();
            hasItem = true;
        }
    }

    private void PressQ()
    {
        if (Input.GetKeyDown(KeyCode.Q) && hasItem == true)
        {
            ItemPickup.DropItem();
            hasItem = false;
        }
    }
}
