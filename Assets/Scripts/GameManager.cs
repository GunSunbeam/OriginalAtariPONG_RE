using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scoreP1, scoreP2;
    public ScoreText scoreText_p1, scoreText_p2;
            public GameObject ball;


    public void OnScoreZoneReached (int id)
    {

        this.ball = GameObject.Find("ball");

        if (id == 1)
        {
            if (ball.transform.position.x < 0)
                scoreP1++;
            else
                scoreP2++;
            
        }
    }
}
