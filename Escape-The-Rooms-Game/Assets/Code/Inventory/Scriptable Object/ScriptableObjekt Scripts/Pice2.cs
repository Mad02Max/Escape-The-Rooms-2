using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Puzzle Pice 2", menuName = "Inventory System/Items/Pice2")]
public class Pice2 : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.pice2;
    }

}
