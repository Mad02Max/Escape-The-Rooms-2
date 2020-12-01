using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Makes it so you pick up an item
    public InventoryObject inventory;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            inventory.Load();
        }
    }

    /*public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();

        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }*/

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
