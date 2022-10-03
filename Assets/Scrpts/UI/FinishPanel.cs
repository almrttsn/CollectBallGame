using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPanel : UIPanel
{
    [SerializeField] private GameObject _winPanel; 
    [SerializeField] private GameObject _losePanel;

    public override void Initialize(UIManager uiManager)
    {
        base.Initialize(uiManager);
        GameManager.EventManager.OnLevelStarted += RefreshPanels;
        GameManager.EventManager.OnLevelFinished += SetFinishPanel;
    }

    private void OnDestroy()
    {
        GameManager.EventManager.OnLevelStarted -= RefreshPanels;
        GameManager.EventManager.OnLevelFinished -= SetFinishPanel;
    }

    private void RefreshPanels()
    {
        _winPanel.SetActive(false);
        _losePanel.SetActive(false);
    }

    private void SetFinishPanel(bool isSuccess)
    {
        if (isSuccess == true)
        {
            _winPanel.SetActive(true);
        }
        else
        {
            _losePanel.SetActive(true);
        }
    }
}
