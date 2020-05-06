using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    
    private bool inRange = false;
    private GameObject playerOnCollision;
    private Transform handPos;
    private Transform thisItem;
    // Start is called before the first frame update
    void Start()
    {
        thisItem = GetComponent<Transform>();
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
            Debug.Log(PlayerInteraction.hasItem);
           playerOnCollision = collision.gameObject;
            handPos = collision.gameObject.transform.GetChild(0).transform ;
            inRange = true;
        }
    }

   private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("out of range");
            inRange = false;
        }
    }

    private void Pickup()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange && PlayerInteraction.hasItem == false)
        {
            thisItem.transform.localScale = playerOnCollision.transform.localScale;
           
            Debug.Log("pickup");
            thisItem.transform.position = handPos.position;
            thisItem.transform.parent = playerOnCollision.transform;
            PlayerInteraction.hasItem = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && PlayerInteraction.hasItem == true)
        {
            Debug.Log("drop item");
            thisItem.parent = null;
            //thisItem.position = new Vector3(0, 0, 0);
            PlayerInteraction.hasItem = false;
        }
    }
}
