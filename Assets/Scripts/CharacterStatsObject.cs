using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class CharacterStatsObject : ScriptableObject
{
    public string _name;
    public float _initialHealth;
    public float _currentCharacterHealth;
    public float _characterMental;
}