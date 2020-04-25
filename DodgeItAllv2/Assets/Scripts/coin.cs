using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float RotationPerSecond;
    public float destroyTime;

    private void Start()
    {
        RotationPerSecond *= 360;
        Destroy(gameObject, destroyTime);
    }
    void Update()
    {
        transform.Rotate(0, 0, RotationPerSecond * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        Destroy(gameObject);
    }
}
