using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public event Action OnLevelStarted;
    public event Action <bool> OnLevelFinished;

    public  void Initialize(GameManager gameManager)
    {

    }

    public void LevelStarted()
    {
        OnLevelStarted?.Invoke();
    }

    public void LevelComplete()
    {
        OnLevelFinished?.Invoke(true);
    }

    public void LevelFailed()
    {
        OnLevelFinished?.Invoke(false);
    }

    
}
