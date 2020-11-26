using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory System/Items/Database")]
public class ItemDataBaseObject : ScriptableObject, ISerializationCallbackReceiver
{

    // En array med alla items i mitt spel
    public ItemObject[] items;

    public Dictionary<ItemObject, int> getId = new Dictionary<ItemObject, int>();
    public Dictionary<int, ItemObject> getItem = new Dictionary<int, ItemObject>();

    public void OnAfterDeserialize()
    {
        // gör så att den alltid resetas
        getId = new Dictionary<ItemObject, int>();

        getItem = new Dictionary<int, ItemObject>();


        // Håller koll på alla mina items
        for (int i = 0; i< items.Length; i++)
        {
            getId.Add(items[i], i);
            getItem.Add(i, items[i]);
        }
    }

    public void OnBeforeSerialize()
    {

    }
}
