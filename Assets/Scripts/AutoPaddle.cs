using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPaddle : MonoBehaviour
{
    public EventHandler moveLeft;
    public EventHandler moveRight;
    public Ball ball;


    void Update()
    {
       if (ball.transform.position.x - transform.position.x > 0.5f)
       {
            moveRight?.Invoke(this, EventArgs.Empty);
       }
       else if (transform.position.x - ball.transform.position.x > 0.5f)
       {
            moveLeft?.Invoke(this, EventArgs.Empty);
       }
    }
}
