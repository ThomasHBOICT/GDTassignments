using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndShoot : MonoBehaviour
{
    public float shootForce;
    Vector2 mouseWorldPointDown;
    Vector2 mouseWorldPointUp;
    Vector2 targetToMouse;
    Vector2 mouseDownToUp;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Aiming();
    }

    void Aiming()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mouseWorldPointDown = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetToMouse = mouseWorldPointDown - rb.position;

           
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            mouseWorldPointUp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseDownToUp = mouseWorldPointDown - mouseWorldPointUp;
            rb.AddForce(mouseDownToUp * shootForce, ForceMode2D.Impulse);
        }
       
    }
}
