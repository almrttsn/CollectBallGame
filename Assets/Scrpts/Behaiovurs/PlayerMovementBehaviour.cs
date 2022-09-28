using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _triggerObject;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _playerMovementSpeed;
    [SerializeField] private float _playerMovementFactor;
    [SerializeField] private GameObject _ball;

    private bool _isPlayerLocked;

    private void Start()
    {
        BallCreateProcess();
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

    private void BallCreateProcess()
    {
        var ball = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(10f, 30f)), Quaternion.identity);
        var ball1 = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(10f, 30f)), Quaternion.identity);
        var ball2 = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(10f, 30f)), Quaternion.identity);
        var ball3 = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(10f, 30f)), Quaternion.identity);
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
