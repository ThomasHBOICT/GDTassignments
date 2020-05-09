using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float maxSpawnTimer;

    public GameObject portalPrefab;
    public float maxPortalTimer;

    private float spawnTimer;
    private float portalTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        SpawnPortal();
    }

    private void SpawnEnemy()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= maxSpawnTimer)
        {

            float Xrange = Random.Range(-8, 8);
            float Yrange = Random.Range(-4.5f, 4.5f);

            Vector3 spawnPos = new Vector3(Xrange, Yrange, 1);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            spawnTimer = 0f;
        }
    }

    private void SpawnPortal()
    {
        portalTimer += Time.deltaTime;

        if (portalTimer >= maxPortalTimer)
        {

            float Xrange = Random.Range(-7, 7);
            float Yrange = Random.Range(-3f, 3f);

            Vector3 spawnPos = new Vector3(Xrange, Yrange, 1);
            Instantiate(portalPrefab, spawnPos, Quaternion.identity);
            portalTimer = 0f;
        }
    }
}
