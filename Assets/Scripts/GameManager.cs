using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scoreP1, scoreP2;
    public ScoreText scoreText_p1, scoreText_p2;


    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
            scoreP1++;
            
        if (id == 2)
            scoreP2++;

        UpdateScores();
    }

    private void UpdateScores()
    {
        scoreText_p1.SetScore(scoreP1);
        scoreText_p2.SetScore(scoreP2);
    }

}
