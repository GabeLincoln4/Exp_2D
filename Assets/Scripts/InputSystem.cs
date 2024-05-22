using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public GameEvent _onAttackInputEvent;

    public void Update() 
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            _onAttackInputEvent.Raise();
        } 
    } 
}
