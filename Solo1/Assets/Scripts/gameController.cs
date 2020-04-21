using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [Header("Scripts")]
    public scoreUpdate updater;
    public shooting shooting;
    public UIcontrol UI;
    public playerHealth playerHealth;

    [Header("Stats")]
    public int health = 3;
    public int score = 0;

    [Header("Coin")]
    public int coinsOwned = 0;
    public bool shopOpen = false;
    public int coinScore = 20;
    public float coinSpawnTime;
    public GameObject coinPrefab;

    [Header("Attack speed, level gets more difficult every __ seconds")]
    public float moreDifficult;


    // privates
    private float difficultyTimer = 1f;
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
        gameDifficulty();
        OpenCloseShop();
    }

    private void scoreTime()
    {
        timer += Time.deltaTime;

        if (timer >= delayAmount)
        {
            Debug.Log("score added");
            timer = 0f;
            scoreUpdater(1);
        }
    }

    public void CoinPickup()
    {
        coinUpdater(1);
        scoreUpdater(coinScore);
    }

    private void OpenCloseShop()
    {
        if (coinsOwned >= 10)
        {
            shopOpen = true;
            UI.OpenShop();
        }
        else
        {
            shopOpen = false;
            UI.CloseShop();
        }
    }
    
    public void LifeBought()
    {
        coinUpdater(-10);
        playerHealth.health += 1;
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

    private void gameDifficulty()
    {
        difficultyTimer += Time.deltaTime;

        if (difficultyTimer >= moreDifficult)
        {
            shooting.Difficulty();
            Debug.Log("more difficult nao");
            difficultyTimer = 0f;
        }
    }

    private void scoreUpdater(int upValue)
    {
        score += upValue;
        updater.score = score;
        updater.ScoreUpdate();
    }

    private void coinUpdater(int coinValue)
    {
        coinsOwned += coinValue;
        updater.coins = coinsOwned;
        updater.CoinUpdate();
    }
}
