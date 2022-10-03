using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementBehaviour : MonoBehaviour
{
    public bool IsPlayerLockedToMove;

    //[SerializeField] private GameObject _parkourEndTrigger;
    //[SerializeField] private GameObject _levelEndTrigger;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _playerMovementSpeed;
    [SerializeField] private float _playerMovementFactor;
    [SerializeField] private Text _levelEndText;    
    [SerializeField] private Text _startText;
    [SerializeField] private Button _restartButton;
    [SerializeField] private ParticleSystem _confettiParticle;

    private GameManager _gameManager;
    private bool _isObjectTriggered;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        IsPlayerLockedToMove = false;
        InputController.OnDrag += PlayerMovementXAxis;
        StartCoroutine(StartTextCo());
        _gameManager.EventManager.OnLevelStarted += ResetPlayer;
    }

    private void Update()
    {
        if (IsPlayerLockedToMove == false)
        {
            transform.position += new Vector3(0, 0, _playerMovementSpeed) * _playerMovementFactor * Time.deltaTime;
        }

        if(transform.position.y < -10f)
        {
            RestartLevel();
        }
    }

    private void ResetPlayer()
    {
        transform.position = new Vector3(0,1,12);
        IsPlayerLockedToMove = false;
        _isObjectTriggered = false;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    private void OnDestroy()
    {
        InputController.OnDrag -= PlayerMovementXAxis;
        _gameManager.EventManager.OnLevelStarted -= ResetPlayer;
    }

    private void PlayerMovementXAxis(Vector2 dragVector)
    {
        transform.position += new Vector3(dragVector.x, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ParkourEnd" && _isObjectTriggered == false)
        {
            Debug.Log("Triggered");
            IsPlayerLockedToMove = true;
            _isObjectTriggered = true; //instead of //Destroy(other.gameObject);
            //add no movement
            StartCoroutine(ShowRestartButton());
        }

        if(other.gameObject.tag == "LevelEnd")
        {
            IsPlayerLockedToMove = true;
            _levelEndText.SetActive(true);
            _confettiParticle.Play();
            //add no movement
            _gameManager.EventManager.LevelComplete();
        }
    }

    private IEnumerator StartTextCo()
    {
        _startText.SetActive(true);
        yield return new WaitForSeconds(3f);
        _startText.SetActive(false);
    }

    private IEnumerator ShowRestartButton()
    {
        yield return new WaitForSeconds(7f);
        _restartButton.SetActive(true);
    }

}
