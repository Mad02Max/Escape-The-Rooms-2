using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class RemoveFromInventory : MonoBehaviour
    {

        public InventoryObject inventory;

        public void Update()
        {
            var item = GetComponent<Item>();
            
            if (Input.GetKeyDown(KeyCode.F))
            {
                inventory.RemoveItem(item.item, -1);
            }

        }

    }
}
