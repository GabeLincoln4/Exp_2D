using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private FloatVariableObject _enemyHP;

    [SerializeField]
    private FloatVariableObject _enemyLuck;

    [SerializeField]
    private float _damageTaken;

    [SerializeField]
    private float _initialLuck;

    private void OnEnable()
    {
        _enemyLuck._value = _initialLuck;
    }

    private void OnDisable ()
    {
        _enemyLuck._value = _initialLuck;
    }
    
    public void DecrementLuck()
    {
        _enemyLuck._value -= _damageTaken;
    }
}