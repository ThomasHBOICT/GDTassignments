using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public scoreUpdate updater;

    [Header("Stats")]
    public float health = 3;
    public float score = 0;

    [Header("Coin")]
    public float coinScore = 20;
    public float coinSpawnTime;
    public GameObject coinPrefab;
    

    private float coinTimer = 0f;
    private float timer = 0f;
    private float delayAmount = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTime();
        SpawnCoin();
    }

    private void scoreTime()
    {
        timer += Time.deltaTime;

        if (timer >= delayAmount)
        {
            Debug.Log("score added");
            timer = 0f;
            score += 1;
            updater.score = score;
            updater.ScoreUpdate();
        }
    }

    public void CoinPickup()
    {
        score += coinScore;
        updater.ScoreUpdate();
    }

    private void SpawnCoin()
    {
        coinTimer += Time.deltaTime;

        if (coinTimer >= coinSpawnTime)
        {

            float Xrange = Random.Range(-8, 8);
            float Zrange = Random.Range(-8, 8);

            Vector3 spawnPos = new Vector3(Xrange, 1, Zrange);
            Instantiate(coinPrefab, spawnPos, Quaternion.Euler(0, 0, 90));
            coinTimer = 0f;
        }
    }
}
