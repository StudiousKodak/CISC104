using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{   
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here
        // Makes the ball smaller
        OtherBall.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);
    }
}

