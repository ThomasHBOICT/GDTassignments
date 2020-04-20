using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreUpdate : MonoBehaviour
{
    public TMP_Text field;
    public float score = 0;


    public void ScoreUpdate()
    {
        Debug.Log("score updated");
        field.text = score + "";
    }
}
