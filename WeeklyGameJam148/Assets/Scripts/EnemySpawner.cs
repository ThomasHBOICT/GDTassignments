using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyPrefab;
    public float maxSpawnTimer;

    public GameObject portalPrefab;
    public float maxPortalTimer;

    private float spawnTimer;
    private float portalTimer;
    private Vector3 enemySpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer();
        PortalTimer();
    }

    private void SpawnTimer()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= maxSpawnTimer + 0.2)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        float Xrange = Random.Range(-13f, 13f);
        float Yrange = Random.Range(-6f, 6f);

        enemySpawnPos = new Vector3(Xrange, Yrange, 1);
        if ((enemySpawnPos - player.transform.position).magnitude > 3)
        {
            Instantiate(enemyPrefab, enemySpawnPos, Quaternion.identity);
        }
        else
        {
            SpawnEnemy();
        }
    }

    private void PortalTimer()
    {
        portalTimer += Time.deltaTime;

        if (portalTimer >= maxPortalTimer)
        {
            SpawnPortal();
            portalTimer = 0f;
        }
    }

    private void SpawnPortal()
    {
        float Xrange = Random.Range(-8.3f, 8.3f);
        float Yrange = Random.Range(-1.85f, 1.85f);

        Vector3 spawnPos = new Vector3(Xrange, Yrange, 1);
        if ((spawnPos - player.transform.position).magnitude > 3)
        {
            Instantiate(portalPrefab, spawnPos, Quaternion.identity);
        }
        else
        {
            SpawnPortal();
        }
    }
}
