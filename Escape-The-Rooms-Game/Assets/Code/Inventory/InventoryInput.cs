using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInput : MonoBehaviour
{

    [SerializeField] GameObject inventoryObject;
    [SerializeField] GameObject tutorialObject1;
    [SerializeField] GameObject tutorialObject2;

    [SerializeField] KeyCode[] toggleInventory;
    [SerializeField] KeyCode[] toggleTutorial;
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
        for (int i = 0; i < toggleTutorial.Length; i++)
        {
            if (Input.GetKeyDown(toggleTutorial[i]))
            {
                tutorialObject1.SetActive(!tutorialObject1.activeSelf);
                tutorialObject2.SetActive(!tutorialObject2.activeSelf);
                break;
            }
        }

    }
}
