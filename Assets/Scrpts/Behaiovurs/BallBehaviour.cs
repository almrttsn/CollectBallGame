using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _ball;

    public void Initialize(GameManager gameManager)
    {
        BallCreateProcess();
    }

    private void BallCreateProcess()
    {
        var ball = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(30f, 50f)), Quaternion.identity);
        var ball1 = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(30f, 50f)), Quaternion.identity);
        var ball2 = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(30f, 50f)), Quaternion.identity);
        var ball3 = Instantiate(_ball, new Vector3(Random.Range(-10f, 10f), 0, Random.Range(30f, 50f)), Quaternion.identity);
    }

}
