using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    public AudioSource S_wall;
    public AudioSource S_score;
    public AudioSource S_paddle;
    public AudioSource S_gameover;

    public Text score_p1;
    public Text score_p2;
    public Text p1_win;
    public Text p2_win;
    public Animator[] win_ani;

    public GameObject ball;
    public Transform ballTr;
    public Rigidbody2D ballRg;
    
    public SpriteRenderer[] paddleSr;
    public BoxCollider2D[] paddleCol;

}
