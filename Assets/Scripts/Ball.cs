using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  public GameManager gameManager;
  public Rigidbody2D rb2d;
  public float maxInitialAngle = 0.8f;
  public float moveSpeed = 5.0f;
  public float startX = 0f;
  public float maxStartY = 4.5f;

  private void Start()
  {
    InitialPush();   
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

  // private void OnTriggerEnter2D (Collider2D collision)
  // {
  //   ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
  //   if(scoreZone)
  //   {
  //     gameManager.OnScoreZoneReached(scoreZone.id);
  //     ResetBall();
  //     InitialPush();
  //   }
  // }

  private void OnTriggerEnter2D (Collider2D collision)
  {
    if(collision.gameObject.tag == "scorezone")
    {
      ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
      gameManager.OnScoreZoneReached(scoreZone.id);
      ResetBall();
      InitialPush();
    }
  }

}
