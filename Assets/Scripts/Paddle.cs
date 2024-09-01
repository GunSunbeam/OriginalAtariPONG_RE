using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameObject paddle;
    public float paddleSpeed = 0.07f;

    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;

    
    void Update()
    {
        rb2d.velocity = Vector2.zero;
        if (Input.GetKey(upKey))
            Up();
        if (Input.GetKey(downKey))
            Down();
        if (Input.GetKey(rightKey))
            Right();
        if (Input.GetKey(leftKey))
            Left();   
    }

    private void Up()
    {
        // Vector2 vec = transform.position;
        // vec.y += paddleSpeed;
        // transform.position = vec;
        rb2d.velocity = Vector2.up * paddleSpeed;
    }
    private void Down()
    {
        // Vector2 vec = transform.position;
        // vec.y -= paddleSpeed;
        // transform.position = vec;
        rb2d.velocity = Vector2.down * paddleSpeed;
    }
    private void Right()
    {
        // Vector2 vec = transform.position;
        // vec.x += paddleSpeed;
        // transform.position = vec;
        rb2d.velocity = Vector2.right * paddleSpeed;
    }
    private void Left()
    {
        // Vector2 vec = transform.position;
        // vec.x -= paddleSpeed;
        // transform.position = vec;
        rb2d.velocity = Vector2.left * paddleSpeed;
    }

}
