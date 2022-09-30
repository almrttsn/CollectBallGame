using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementBehaviour : MonoBehaviour
{
    public bool IsPlayerLockedToMove;
    [SerializeField] private GameObject _parkourEndTrigger;
    [SerializeField] private GameObject _levelEndTrigger;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _playerMovementSpeed;
    [SerializeField] private float _playerMovementFactor;
    [SerializeField] private Text _levelEndText;    
    [SerializeField] private Text _startText;

    private GameManager _gameManager;
    private bool _isObjectTriggered;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        IsPlayerLockedToMove = false;
        InputController.OnDrag += PlayerMovementXAxis;
        StartCoroutine(StartTextCo());
    }

    private void Update()
    {
        if (IsPlayerLockedToMove == false)
        {
            transform.position += new Vector3(0, 0, _playerMovementSpeed) * _playerMovementFactor * Time.deltaTime;
        }

        if(transform.position.y < -10f)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void PlayerMovementXAxis(Vector2 dragVector)
    {
        transform.position += new Vector3(dragVector.x, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == _parkourEndTrigger && _isObjectTriggered == false)
        {
            Debug.Log("Triggered");
            IsPlayerLockedToMove = true;
            _isObjectTriggered = true; //instead of //Destroy(other.gameObject);
            //add no movement
        }

        if(other.gameObject == _levelEndTrigger)
        {
            IsPlayerLockedToMove = true;
            _levelEndText.SetActive(true);
            //add no movement
        }
    }

    private IEnumerator StartTextCo()
    {
        _startText.SetActive(true);
        yield return new WaitForSeconds(3f);
        _startText.SetActive(false);
    }

}
