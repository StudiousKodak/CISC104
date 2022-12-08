using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // Homework: Do something interesting here
        OtherBall.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
    }
}

