using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldRotator : MonoBehaviour
{
    Quaternion rotation;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        RotateShield();
    }


    private void RotateShield()
    {
        if(Input.GetAxis("RightVertical") == 0 && Input.GetAxis("RightHorizontal") == 0)
        {
            rb.transform.rotation = rotation;
        }
        else
        {
            rotation = Quaternion.Euler(0, Mathf.Atan2(Input.GetAxis("RightVertical"), Input.GetAxis("RightHorizontal")) * 180 / Mathf.PI, 0);
            rb.transform.rotation = rotation;
        }
    }
}
