using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Color[] colors;
    void Start()
    {
        Color randomColor = colors[Random.Range(0, colors.Length)];
        gameObject.GetComponent<Renderer>().material.color = randomColor;
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
