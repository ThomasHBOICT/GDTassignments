using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public EnemySpawner enemySpawn;
    [Header("More difficult every: __")]
    public int maxTimer;
    [Header("Spawn timer factor")]
    public float spawnTimerFactor;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= maxTimer)
        {
            MakeMoreDifficult();
            timer = 0f;
        }
    }

    private void MakeMoreDifficult()
    {
        enemySpawn.maxSpawnTimer *= spawnTimerFactor;
    }
}
