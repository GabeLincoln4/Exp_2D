using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputSystem : MonoBehaviour
{
    public GameEvent _onAttackInputEvent;
    public GameEvent _onAttackInputEventEnd;
    public GameEvent _onMagicAttackInputInvoked;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            _onAttackInputEvent.Raise();
        } 
        
        if (Input.GetButton("Fire1"))
        {
            _onAttackInputEvent.Raise();
        }

        if (Input.GetButtonUp("Fire1"))
        {
            _onAttackInputEventEnd.Raise();
        }

        if (Input.GetButtonDown("Magic Attack"))
        {
            _onMagicAttackInputInvoked.Raise();
        }

    } 
}
