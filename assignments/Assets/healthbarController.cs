using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class healthbarController : MonoBehaviour
{
    // Start is called before the first frame update
    public playerStats stats;
    UnityEvent onhealthChanged = new UnityEvent();

    private Slider healthbar;
    private float maxHealth;

    void Start()
    {
        healthbar = GetComponent<Slider>();
        maxHealth = stats.maxHealth;
        onhealthChanged.AddListener(healthbarUpdate);
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.healthChanged)
        {
            onhealthChanged.Invoke();
            stats.healthChanged = false;
        }
    }

    private void healthbarUpdate()
    {
        healthbar.value = (float)(((decimal)stats.currentHealth / (decimal)maxHealth) * 100 );
        Debug.Log(healthbar.value);

    }

}
