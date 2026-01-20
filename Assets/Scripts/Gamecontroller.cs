using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour

{
    [SerializeField] private TMPro.TMP_Text scoreText;
    private int score = 0;
    void Start()
    {
        UpdateScoreUI();
    }

    public void Addscore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }
    private void UpdateScoreUI()
    {
        scoreText.text = "Coin: " + score;
    }
    void Update()
    {
        
    }
}
