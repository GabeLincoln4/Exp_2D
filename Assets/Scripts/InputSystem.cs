using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputSystem : MonoBehaviour
{
    public GameEvent _onAttackInputEvent;
    public GameEvent _onAttackInputEventEnd;
    public GameEvent _onMagicAttackInputInvoked;
    public GameEvent _onUnwelcomeContemplationAndSummonInvoked;
    [SerializeField]
    private BooleanVariableObject _magicAttackIsRaised;

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
            if (!_magicAttackIsRaised._value)
            {
                _onMagicAttackInputInvoked.Raise();
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            _onUnwelcomeContemplationAndSummonInvoked.Raise();
        }

    } 

    private void OnEnable ()
    {
        SetMagicAttackInputToNotInvoked();
    }

    public void SetMagicAttackInputToInvoked ()
    {
        _magicAttackIsRaised._value = true;
    }

    public void SetMagicAttackInputToNotInvoked ()
    {
        _magicAttackIsRaised._value = false;
    }
}
