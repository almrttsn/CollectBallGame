using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : CustomBehaviour
{
    public UIManager UIManager => _uiManager;
    public PlayerMovementBehaviour PlayerMovementBehaviour => _playerMovementBehaviour;
    public BallBehaviour BallBehaviour => _ballBehaviour;
    public EvaluateBoardBehaviour EvaluateBoardBehaviour => _evaluateBoardBehaviour;
    public InputController InputController => _inputController;

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerMovementBehaviour _playerMovementBehaviour;
    [SerializeField] private BallBehaviour _ballBehaviour;
    [SerializeField] private EvaluateBoardBehaviour _evaluateBoardBehaviour;
    [SerializeField] private InputController _inputController;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Initialize();
    }

    private void Initialize()
    {
        _uiManager.Initialize(this);
        _playerMovementBehaviour.Initialize(this);
        _ballBehaviour.Initialize(this);
        _evaluateBoardBehaviour.Initialize(this);
        _inputController.Initialize(this);
    }
}


