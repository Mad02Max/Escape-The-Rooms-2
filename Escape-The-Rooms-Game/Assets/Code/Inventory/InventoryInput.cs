using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInput : MonoBehaviour
{

    [SerializeField] GameObject inventoryObject;

    [SerializeField] KeyCode[] toggleInventory;
    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < toggleInventory.Length; i++)
        {
            if (Input.GetKeyDown(toggleInventory[i]))
            {
                inventoryObject.SetActive(!inventoryObject.activeSelf);
                break;
            }
        }
    }
}
