using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Default
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject _prefab;
    public ItemType _type;
    [TextArea(15, 20)]
    public string _description;
}
