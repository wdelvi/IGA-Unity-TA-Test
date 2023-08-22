using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text ballText;

    private int score;

    public void SetNumBalls(int numBalls)
    {
        ballText.SetText("BALLS: " + numBalls);
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.SetText("SCORE:  + score");
    }
}
