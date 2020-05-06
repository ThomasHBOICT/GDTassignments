using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{    
    private Transform playerOnCollision;
    private Transform handPos;
    private Transform thisItem;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Player")
        {
            playerOnCollision = collision.GetComponent<Transform>();
            handPos = collision.gameObject.transform.GetChild(0).transform;
        }
    }
    public void Pickup()
    {
        transform.localScale = playerOnCollision.transform.localScale;
        Debug.Log("pickup");
        transform.position = handPos.position;
        transform.parent = playerOnCollision.transform;
        PlayerInteraction.hasItem = true;
    }

    public void DropItem()
    {
        Debug.Log("drop item");
        transform.parent = null;
        PlayerInteraction.hasItem = false;
    }

    public void yeet()
    {
        Debug.Log("yeeeeet!");
    }
}
