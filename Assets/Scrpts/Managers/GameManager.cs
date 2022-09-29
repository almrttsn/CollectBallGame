using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : CustomBehaviour
{
    public UIManager UIManager => _uiManager;
    public PlayerMovementBehaviour PlayerMovementBehaviour => _playerMovementBehaviour;
    public BallBehaviour BallBehaviour => _ballBehaviour;
     
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerMovementBehaviour _playerMovementBehaviour;
    [SerializeField] private BallBehaviour _ballBehaviour;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Initialize()
    {
        _uiManager.Initialize(this);
        _playerMovementBehaviour.Initialize(this);
        _ballBehaviour.Initialize(this);
    }
}


