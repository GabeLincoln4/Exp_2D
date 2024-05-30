using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Inventory Object", menuName= "Inventory System/Inventory Slot")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> _container = new List<InventorySlot>(); 
    public void AddItem()
    {
        {
            _container.Add(new InventorySlot());
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject _item;
    public int _amount;
    public InventorySlot()
    {
        
    }
    public void AddAmount(int value)
    {
        _amount += value;
    }
}
