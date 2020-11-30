using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Food,
    Equipment,
    Default,
    pice1,
    pice2
}
public abstract class ItemObject : ScriptableObject
{

    public GameObject prefab;

    public ItemType type;

    [TextArea(15,20)]
    public string desctiption;
}
