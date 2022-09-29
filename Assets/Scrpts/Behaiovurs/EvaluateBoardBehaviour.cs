using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaluateBoardBehaviour : MonoBehaviour
{
    private GameManager _gameManager;
    private BallBehaviour _droppedBall;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Ball dropped");
        }
    }
}
