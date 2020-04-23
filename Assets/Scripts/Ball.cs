using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private Paddle paddle;

    private Rigidbody2D rb;
    private float xPush = 2f;
    private float yPush = 15f;
    private float paddleOffset = 0.3f;
    private bool started = false;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!started)
        {
            StickToPaddle();
            CheckForStart();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }

    void StickToPaddle()
    {
        transform.position = paddle.transform.position + new Vector3(0, paddleOffset, 0);
    }

    void CheckForStart()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            started = true;
            rb.velocity = new Vector2(xPush, yPush);
        }
    }



}
