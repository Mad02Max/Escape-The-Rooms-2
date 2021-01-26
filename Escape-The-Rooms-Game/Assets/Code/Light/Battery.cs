using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public float batteryLife = 300;
    public float currentBattery;
    public bool on;
    public Text batterText;


    public void Awake()
    {
        on = false;
        currentBattery = batteryLife;
    }

    public void Update()
    {
        if (on == false)
        {
            currentBattery = currentBattery;
        }
        if (on == true)
        {
            batteryLife = batteryLife - 1 * Time.deltaTime;
            currentBattery = batteryLife;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            on = !on;
        }

        batterText.text = "Seconds left in battery = " + currentBattery;


    }

}
