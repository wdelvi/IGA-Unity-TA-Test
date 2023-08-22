using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnCollision : MonoBehaviour
{
    public int scoreToAdd;
    public UIController uIController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        uIController.AddScore(scoreToAdd);
    }
}
