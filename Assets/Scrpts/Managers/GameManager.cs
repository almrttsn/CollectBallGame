using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : CustomBehaviour
{
    public UIManager UIManager => _uiManager;
    public PlayerMovementBehaviour PlayerMovementBehaviour => _playerMovementBehaviour;
    //public BallBehaviour BallBehaviour => _ballBehaviour;
    //public EvaluateBoardBehaviour EvaluateBoardBehaviour;
    public InputController InputController => _inputController;
    public LevelManager LevelManager => _levelManager;
    public EventManager EventManager => _eventManager;


    [SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerMovementBehaviour _playerMovementBehaviour;
    //[SerializeField] private BallBehaviour _ballBehaviour;
    //[SerializeField] private EvaluateBoardBehaviour _evaluateBoardBehaviour; //inPrefab
    [SerializeField] private InputController _inputController;
    [SerializeField] private LevelManager _levelManager;
    [SerializeField] private EventManager _eventManager;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Initialize();
        _eventManager.LevelStarted();
    }

    private void Initialize()
    {
        _eventManager.Initialize(this);
        _uiManager.Initialize(this);
        _inputController.Initialize(this);
        _levelManager.Initialize(this);
        _playerMovementBehaviour.Initialize(this);
        //_evaluateBoardBehaviour.Initialize(this);
    }
}


