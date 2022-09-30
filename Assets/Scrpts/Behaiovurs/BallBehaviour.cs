using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //[SerializeField] List<GameObject> _ballList = new List<GameObject>();
    [SerializeField] private GameObject _ball;
    [SerializeField] int _desiredBallCount;
    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        BallCreateProcess();
    }

    private void BallCreateProcess()
    {
        for (int i = 0; i < _desiredBallCount; i++)
        {
            Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity);
        }
    }

}
