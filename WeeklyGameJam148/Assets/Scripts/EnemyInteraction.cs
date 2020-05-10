using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    public bool isCoin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!isCoin)
            {
                Debug.Log("Player damaged.");
            }
            else
            {
                Debug.Log("Player got coin.");
                Destroy(gameObject);
            }
        }
    }
}
