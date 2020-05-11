using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    public bool isCoin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && isCoin)
        {
            Debug.Log("got a coin, pimpin aint easy.");
            Destroy(gameObject);
        }
    }
}
