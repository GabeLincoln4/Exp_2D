using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    [SerializeField]
    private FloatVariableObject _characterHP;

    [SerializeField]
    private FloatVariableObject _characterLuck;

    [SerializeField]
    private float _initialLuck;

    private void OnEnable()
    {
        _characterLuck._value = _initialLuck;
    }

    private void OnDisable ()
    {
        _characterLuck._value = _initialLuck;
    }
    
    public void DecrementLuck(float damageTaken)
    {
        _characterLuck._value -= damageTaken;
    }
}