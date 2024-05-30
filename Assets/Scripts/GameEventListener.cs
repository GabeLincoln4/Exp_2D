using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent _gameEvent;
    public UnityEvent<ItemObject, int> _response;
    public ItemObject _itemObject;
    public int _amountOfItem;

    void OnEnable()
    {
        _gameEvent.RegisterListener(this);
    }

    void OnDisable()
    {
        _gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised ()
    {
        _response.Invoke(_itemObject, _amountOfItem);
    }
}