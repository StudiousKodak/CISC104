using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public GameObject Color;
    
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here
        OtherBall.material.color = Color.white;
    }
}

