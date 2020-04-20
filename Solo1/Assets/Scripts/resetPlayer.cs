using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour
{
    public Rigidbody playerRb;
    public void resetPlayerPos()
    {
        playerRb.position = new Vector3(0, 1, 0);
    }
}
