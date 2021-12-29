using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class scoreController : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        refreshUI();
    }
    public void IncreseScore(int increment)
    {
        score += increment;
        refreshUI();
    }
    private void refreshUI()
    {
        scoreText.text = "Score:" + score;
    }
}
