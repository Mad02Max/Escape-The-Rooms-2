using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class DestroyInteractable : InteractableBase
    {
        public InventoryObject inventory;
        public override void OnInteract()
        {
            base.OnInteract();

            Destroy(gameObject);

            var item = GetComponent<Item>();

            if (item)
            {
                inventory.AddItem(item.item, 1); 
            }

        }

    }
}
