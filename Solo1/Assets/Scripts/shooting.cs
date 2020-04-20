using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform shootRotator;
    public float bulletSpeed;
    public float attackSpeed;
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
        float randomTime = Random.Range(0.1f, 0.6f);

        Shoot();

        Invoke("ShootTiming", randomTime);
    }
}
