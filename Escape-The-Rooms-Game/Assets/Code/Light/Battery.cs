using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//By Caleb

public class Battery : MonoBehaviour
{
    //Creates a float that is the battery life in seconds.
    //Creates a float that is always the current batter life.
    //Creates a bool for whetever the light is on or off.
    //Creates a text to show the battery life.
    //Creates a life to interact with unity.
    public float batteryLife = 90;
    public float currentBattery;
    public bool on;
    public Text batterText;
    public Light flashlight;

    public Slider batterySlider;



    //Turns on to false at the start.
    //Makes current battery equal to battery life at the start.
    //Has the flashlight be off at the start.
    public void Awake()
    {
        on = false;
        currentBattery = batteryLife;
        flashlight.enabled = false;
    }

    //Makes it so that the ligft is off if on is false.
    //Have the light be on, and the battery go down, if on is true.
    //Turns on true and false with "Q".
    //Makes it so that the battery can't go below 0, and so that when it is 0; on becomes false.
    //Makes current battery equal to battery life at all times.
    //Changes the text that shows battery life.
    public void Update()
    {
        if (on == false)
        {
            flashlight.enabled = false;
        }

        if (on == true)
        {
            batteryLife = batteryLife - 1 * Time.deltaTime;
            flashlight.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            on = !on;
        }

        if (batteryLife <= 0)
        {
            batteryLife = 0;
            on = false;
        }

        currentBattery = batteryLife;
        batterText.text = "Seconds left in battery = " + currentBattery;



        batterySlider.value = currentBattery;
    }

}
