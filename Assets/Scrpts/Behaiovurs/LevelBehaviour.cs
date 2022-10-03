using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour
{
    public EvaluateBoardBehaviour EvaluateBoardBehaviour => _evaluateBoardBehaviour;

    [SerializeField] private EvaluateBoardBehaviour _evaluateBoardBehaviour;
    [SerializeField] private BallBehaviour _ballBehaviour;
    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        _ballBehaviour.Initialize();
        _evaluateBoardBehaviour.Initialize(_gameManager);
    }

}
