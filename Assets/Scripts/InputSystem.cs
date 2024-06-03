using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputSystem : MonoBehaviour
{
    public GameEvent _onAttackInputEvent;
    public GameEvent _onAttackInputEventEnd;
    public GameEvent _onMagicAttackInputInvoked;
    private bool _magicAttackInputInvoked = false;

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
            if (!_magicAttackInputInvoked)
            {
                _onMagicAttackInputInvoked.Raise();
                Debug.Log("Magic Attack Inovked");
            }
        }

    } 

    public void SetMagicAttackInputToInvoked ()
    {
        _magicAttackInputInvoked = true;
    }

    public void SetMagicAttackInputToNotInvoked ()
    {
        _magicAttackInputInvoked = false;
    }
}
