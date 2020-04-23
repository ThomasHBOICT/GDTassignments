using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject particles;
    public GameObject inFieldParticle;
    public Color[] colors;
    private Transform tf;
    
   
    void Start()
    {
        tf = GetComponent<Transform>();
        Color randomColor = colors[Random.Range(0, colors.Length)];
        gameObject.GetComponent<Renderer>().material.color = randomColor;
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particles, tf.position, Quaternion.Euler(-90, 0 ,0));
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Field")
        {
            Instantiate(inFieldParticle, tf.position, Quaternion.Euler(-90, 0, 0));
        }
    }
}
