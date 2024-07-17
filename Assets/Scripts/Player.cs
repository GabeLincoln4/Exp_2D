using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField]
    private GameEvent _onPlayerDeath;

    [SerializeField]
    private GameEvent _onPlayerSurvival;

    public void CheckForDeath(CharacterStatsObject characterStats)
    {
        bool playerIsDead = false;
        if (characterStats._currentCharacterHealth <= 0)
        {
            playerIsDead = true;
            _onPlayerDeath.Raise();
        }
        else
        {
            _onPlayerSurvival.Raise();
        }
    }
}
