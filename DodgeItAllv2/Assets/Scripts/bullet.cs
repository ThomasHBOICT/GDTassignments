using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Gradient bulletColorGradient;
    public GameObject particles;
    public GameObject infieldParticles;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = bulletColorGradient.Evaluate(Random.Range(0f, 1f));
        Destroy(gameObject, 3f);
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(8, 8);

        if (other.collider.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(particles, rb.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InField")
        {
            Instantiate(infieldParticles, rb.position, Quaternion.identity);
        }
    }
}
