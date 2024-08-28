using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  public Rigidbody2D rb2d;
  public float maxInitialAngle = 0.67f;
  GameObject ball;
  public float moveSpeed = 1.0f;

  private void Start()
  {
    this.ball = GameObject.Find("ball");
    this.ball.transform.Translate (0, Random.Range(-5, 5), 0);
    Vector2 dir = Vector2.left;
    dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
    rb2d.velocity = dir * moveSpeed;
    
  }
}
