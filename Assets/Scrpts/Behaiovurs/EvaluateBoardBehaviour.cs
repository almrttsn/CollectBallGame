using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaluateBoardBehaviour : MonoBehaviour
{
    private GameManager _gameManager;
    private BallBehaviour _droppedBall;
    private int _ballCount;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            _ballCount++;
            Debug.Log("Ball count is " + _ballCount);
        }
    }
}
