using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour
{
    public Text scoreField;
    public Text healthField;
    [HideInInspector]
    public int score = 0;
    public int health = 3;

    public void ScoreUpdate(int addScore)
    {
        score += addScore;
        scoreField.text =  score.ToString();
    }
}
