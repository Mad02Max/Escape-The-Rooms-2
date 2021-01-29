using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Caleb, copied from Max InventoryInput

public class CanvasInput : MonoBehaviour
{
    [SerializeField] GameObject tutorialObject1;
    [SerializeField] GameObject tutorialObject2;
    [SerializeField] GameObject mouseSensitivity;
    [SerializeField] GameObject timerObject;

    [SerializeField] KeyCode[] toggleTutorial;
    [SerializeField] KeyCode[] toggleTimer;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < toggleTutorial.Length; i++)
        {
            if (Input.GetKeyDown(toggleTutorial[i]))
            {
                tutorialObject1.SetActive(!tutorialObject1.activeSelf);
                tutorialObject2.SetActive(!tutorialObject2.activeSelf);
                mouseSensitivity.SetActive(!mouseSensitivity.activeSelf);
                break;
            }
        }
        for (int i = 0; i < toggleTimer.Length; i++)
        {
            if (Input.GetKeyDown(toggleTimer[i]))
            {
                timerObject.SetActive(!timerObject.activeSelf);
                break;
            }
        }

    }
}
