using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float maxSpawnTimer;

    private float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= maxSpawnTimer)
        {

            float Xrange = Random.Range(-8, 8);
            float Zrange = Random.Range(-4.5f, 4.5f);

            Vector3 spawnPos = new Vector3(Xrange, 1, Zrange);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            spawnTimer = 0f;
        }
    }
}
