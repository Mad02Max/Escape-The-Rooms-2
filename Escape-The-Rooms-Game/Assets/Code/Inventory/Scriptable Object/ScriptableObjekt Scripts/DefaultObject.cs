using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Gör så att vi kan höger clicka och skapa ett nytt default object
[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")]

public class DefaultObject : ItemObject
{

    public void Awake()
    {
        type = ItemType.Default;
    }

}
