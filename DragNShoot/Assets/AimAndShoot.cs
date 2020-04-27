using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndShoot : MonoBehaviour
{
    public float shootForce;
    Vector2 mouseWorldPointDown;
    Vector2 mouseWorldPointUp;
    Vector2 mouseDownToUp;
    Rigidbody2D rb;
    private bool canShoot = true;
    private LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Aiming();
        shootState();
        DrawLine();
    }

    void Aiming()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mouseWorldPointDown = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && canShoot)
        {
            mouseWorldPointUp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseDownToUp = mouseWorldPointDown - mouseWorldPointUp;
            rb.AddForce(mouseDownToUp * shootForce, ForceMode2D.Impulse);
            canShoot = false;
        }
    }

    void shootState()
    {
        if (rb.velocity.magnitude < 0.1f)
        {
            canShoot = true;
        }
    }

    void DrawLine()
    {
        while (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 linePointOne = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            line.SetPosition(0, linePointOne);
            line.SetPosition(1, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
