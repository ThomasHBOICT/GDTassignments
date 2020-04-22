using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldSize : MonoBehaviour
{
    public Rigidbody rb;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShieldUp(float scaleSize)
    {
        rb.transform.localScale = rb.transform.localScale + new Vector3(0, 0, scaleSize);
    }
}
