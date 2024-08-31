using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  public GameManager gameManager;
  public Rigidbody2D rb2d;
  public float maxInitialAngle = 1.0f;
  public float moveSpeed = 1.0f;
  public float startX = 0f;
  public float maxStartY = 4.5f;

  private void Start()
  {
    InitialPush();   
  }

  private void Awake()
  {
    gameManager = new GameManager();
  }

  private void InitialPush()
  {
    Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;
    dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
    rb2d.velocity = dir * moveSpeed;
  }

  private void ResetBall()  
  {
    float posY = Random.Range(-maxStartY, maxStartY);
    Vector2 position = new Vector2(startX, posY);
    transform.position = position;
  }

  private void OnTriggerEnter2D (Collider2D collision)
  {
    ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
    if(scoreZone)
    {
      gameManager.OnScoreZoneReached();
      ResetBall();
      InitialPush();
    }
  }

}
