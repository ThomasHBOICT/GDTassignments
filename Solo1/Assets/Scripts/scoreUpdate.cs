using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreUpdate : MonoBehaviour
{
    public TMP_Text scoreField;
    public TMP_Text coinField;
    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public int coins = 0; 

    public void ScoreUpdate()
    {
        scoreField.text =  score.ToString();
    }

    public void CoinUpdate()
    {
        Debug.Log("coins updated");
        coinField.text = coins.ToString() + "X";
    }
}
