using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Inventory Object", menuName= "Inventory System/Inventory Slot")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> _container = new List<InventorySlot>(); 
    public void AddItem(ItemObject item, int amount)
    {
        bool hasItem = false;
        for (int i = 0; i < _container.Count; i++)
        {
            if (_container[i]._item == item)
            {
                _container[i].AddAmount(amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            _container.Add(new InventorySlot(item, amount));
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject _item;
    public int _amount;
    public InventorySlot(ItemObject item, int amount)
    {
        _item = item;
        _amount = amount;
    }
    public void AddAmount(int value)
    {
        _amount += value;
    }
}
