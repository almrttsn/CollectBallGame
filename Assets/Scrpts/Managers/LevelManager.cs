using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    [SerializeField] private List<LevelBehaviour> _levels;
    private LevelBehaviour _currentLevel;
    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        Debug.Log(_gameManager.name);
        Debug.Log(_gameManager.EventManager.name);
        _gameManager.EventManager.OnLevelStarted += LevelStart;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            NextLevel();
        }
    }

    private void OnDestroy()
    {
        _gameManager.EventManager.OnLevelStarted -= LevelStart;
    }

    private void LevelStart()
    {
        ClearLevel();
        if(_levels.Count <= PlayerData.LevelID) //modMethod
        {
            PlayerData.LevelID = 0;
        }
        _currentLevel =  Instantiate(_levels[PlayerData.LevelID]);
        _currentLevel.Initialize(_gameManager);
        //_currentLevel =  Instantiate(_levels[PlayerData.LevelID%_levels.Count]); //modMethod
    }

    private void ClearLevel()
    {
        if(_currentLevel != null)
        {
            Destroy(_currentLevel.gameObject);
        }
    }

    //forButton
    public void RestartLevel()
    {
        _gameManager.EventManager.LevelStarted();
    }

    //forButton
    public void NextLevel()
    {
        PlayerData.LevelID++;
        _gameManager.EventManager.LevelStarted();
    }

    


}
