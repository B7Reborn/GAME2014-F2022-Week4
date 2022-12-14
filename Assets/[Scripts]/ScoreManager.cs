using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


[System.Serializable]
public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreLabel;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetScore(0);
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int newScore)
    {
        score = newScore;
        UpdateScoreLabel();
    }

    public void AddPoints(int numPoints)
    {
        score += numPoints;
        UpdateScoreLabel();
    }

    public void UpdateScoreLabel()
    {
        scoreLabel.text = $"Score: {score}";
    }
}
