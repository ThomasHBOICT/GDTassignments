using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject Item;
    public Transform hand;
    public Transform head;

    public static bool hasItem = false;

    public void HandPickup(GameObject Item)
    {
        Instantiate(Item, hand.transform.position, gameObject.transform.rotation, hand.transform);
    }

    public void HeadPickup(GameObject Item)
    {
        Instantiate(Item, head.transform.position, gameObject.transform.rotation, head.transform);
    }
}
