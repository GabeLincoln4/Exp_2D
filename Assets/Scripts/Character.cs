using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    [SerializeField]
    private CharacterStatsObject _characterStats;

    [SerializeField]
    private float _initialLuck;

    private void OnEnable()
    {
        _characterStats._characterMental = _initialLuck;
    }

    private void OnDisable ()
    {
        _characterStats._characterMental = _initialLuck;
    }
    
    public void DecrementMorale(float damageTaken)
    {
        _characterStats._characterMental -= damageTaken;
    }
}