using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHealth;
    public bool healthChanged = false;

    [HideInInspector]
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger && collision.tag == "spikes")
        {
            currentHealth -= 10;
            Debug.Log("damaged");
            healthChanged = true;
        }
    }
}
