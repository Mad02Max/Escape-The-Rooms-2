using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Puzzle Pice 2", menuName = "Inventory System/Items/Pice1")]
public class PuzzlePice1 : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.pice1;
    }

}
