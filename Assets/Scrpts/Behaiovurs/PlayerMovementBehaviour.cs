using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _triggerObject;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _playerMovementSpeed;
    [SerializeField] private float _playerMovementFactor;

    private GameManager _gameManager;

    private bool _isPlayerLocked;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        _isPlayerLocked = false;
    }    

    private void Update()
    {
        if (_isPlayerLocked == false)
        {
            transform.position += new Vector3(0, 0, _playerMovementSpeed) * _playerMovementFactor * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-_playerMovementSpeed, 0, 0) * _playerMovementFactor * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(_playerMovementSpeed, 0, 0) * _playerMovementFactor * Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == _triggerObject)
        {
            Debug.Log("Triggered");
            _isPlayerLocked = true;
        }
    }
}
