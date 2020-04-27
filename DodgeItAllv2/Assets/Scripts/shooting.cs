﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform shootRotator;
    public float bulletSpeed;

    //[Header("Game get harder by: (0.65 - 0.9)")]
    //public float extraDifficulty;
    [Header("Speed of attack factor:")]
    public float attackSpeed = 2.0f;
    public float minShootTimer = 0.3f;
    public float maxShootTimer = 0.7f;


   
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShootTiming", 0.5f);
    }

    

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, shootRotator.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootRotator.up * bulletSpeed, ForceMode2D.Impulse);
    }

    private void ShootTiming()
    {
        float randomTime = Random.Range(attackSpeed * minShootTimer, attackSpeed * maxShootTimer);

        Shoot();

        Invoke("ShootTiming", randomTime);
    }

    public void Difficulty()
    {
       
           // attackSpeed *= extraDifficulty;
          //  Debug.Log("more difficult nao");
       
    }
}