using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform shootRotator;
    public float bulletSpeed;

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
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootRotator.forward * bulletSpeed, ForceMode.Impulse);
        
        
    }

    private void ShootTiming()
    {
        float randomTime = Random.Range(attackSpeed * minShootTimer, attackSpeed * maxShootTimer);

        Shoot();

        Invoke("ShootTiming", randomTime);
    }

    public void Difficulty()
    {
       
            attackSpeed -= 0.1f;
            Debug.Log("more difficult nao");
       
    }
}
