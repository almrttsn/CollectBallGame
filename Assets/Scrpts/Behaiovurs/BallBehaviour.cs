using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] List<GameObject> _ballList = new List<GameObject>();
    [SerializeField] private GameObject _ball;
    [SerializeField] int _desiredBallCount;

    public void Initialize()
    {        
        BallCreateProcess();
        //_gameManager.EventManager.OnLevelStarted += BallCreateProcess;
    }

    private void BallCreateProcess()
    {
        //if(_ballList.Count > 0)
        //{
        //    for (int i = 0; i < _ballList.Count; i++)
        //    {
        //        Destroy(_ballList[i].gameObject);
        //    }
        //}

        //_ballList = new List<GameObject>();

        for (int i = 0; i < _desiredBallCount; i++)
        {
            var ball = Instantiate(_ball, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(30f, 70f)), Quaternion.identity,transform);
            //_ballList.Add(ball);
        }
    }

}
