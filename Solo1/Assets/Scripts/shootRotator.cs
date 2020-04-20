using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootRotator : MonoBehaviour
{
    public float RotationPerSecond;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotationPerSecond * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
    }
}
