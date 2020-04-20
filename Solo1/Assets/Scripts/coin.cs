using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float RotationPerSecond;

    void Update()
    {
        transform.Rotate(RotationPerSecond * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
