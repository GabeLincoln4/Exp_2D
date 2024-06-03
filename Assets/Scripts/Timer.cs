using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private GameObject _timerGameObject;

    [SerializeField]
    private GameEvent _onTimerOff;

    [SerializeField]
    private FloatVariableObject _timerDurationInSeconds;

    private void OnEnable ()
    {
        StartCoroutine(StartTimer());
    }

    private void OnDisable ()
    {
        _onTimerOff.Raise();
    }

    IEnumerator StartTimer ()
    {
        Debug.Log("Timer started");
        yield return new WaitForSeconds(_timerDurationInSeconds._value);
        Debug.Log("Timer finished");
        _timerGameObject.SetActive(false);
    }
}
