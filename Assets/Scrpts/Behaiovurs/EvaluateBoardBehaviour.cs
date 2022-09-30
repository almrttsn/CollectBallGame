using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaluateBoardBehaviour : MonoBehaviour
{
    private GameManager _gameManager;
    private int _ballCount;
    private int _requiredHeightToPlayerMove;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        _requiredHeightToPlayerMove = (-(int)transform.position.y);
        Debug.Log((-(int)transform.position.y));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            _ballCount++;
            if (_ballCount <= _requiredHeightToPlayerMove)
            {
                BoardHeightUpProcess();
            }
            Destroy(collision.gameObject);
            if (_ballCount == _requiredHeightToPlayerMove)
            {
                _gameManager.PlayerMovementBehaviour.IsPlayerLockedToMove = false;
            }
        }
    }

    private void BoardHeightUpProcess()
    {
        transform.position = new Vector3(0, transform.position.y + 1f, transform.position.z);
    }
}
