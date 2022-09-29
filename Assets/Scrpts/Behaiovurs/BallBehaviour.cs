using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        BallCreateProcess();
    }

    private void BallCreateProcess()
    {
        var ball = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        var ball1 = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        var ball2 = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        var ball4 = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        var ball5 = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        var ball6 = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        var ball7 = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
    }

}
