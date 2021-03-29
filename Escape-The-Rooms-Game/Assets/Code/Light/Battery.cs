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
    //Creates a slider for showing the batter.
    public float batteryLife = 90;
    public float currentBattery;
    public bool on;
    public Text batterText;
    public Light flashlight;
    public Slider batterySlider;

    public Image battery1;
    public Image battery2;
    public Image battery3;
    public Image battery4;
    public Image battery5;


    public Toggle flashLight;

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
    //Makes the slider equal to the battery at all times.
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

            flashLight.isOn = true;
        }

        if (batteryLife <= 0)
        {
            batteryLife = 0;
            on = false;
        }

        currentBattery = batteryLife;
        batterText.text = "Seconds left in battery = " + currentBattery;

        batterySlider.value = currentBattery;

        if (batteryLife == 0)
        {
            battery1.enabled = false;
            battery2.enabled = false;
            battery3.enabled = false;
            battery4.enabled = false;
            battery5.enabled = true;
        }
        if (batteryLife > 270)
        {
            battery1.enabled = true;
            battery2.enabled = false;
            battery3.enabled = false;
            battery4.enabled = false;
            battery5.enabled = false;
        }
        if (batteryLife > 0)
        {
            if (batteryLife < 91)
            {
                battery1.enabled = false;
                battery2.enabled = false;
                battery3.enabled = false;
                battery4.enabled = true;
                battery5.enabled = false;
            }
            if (batteryLife > 90)
            {
                if (batteryLife < 181)
                {
                    battery1.enabled = false;
                    battery2.enabled = false;
                    battery3.enabled = true;
                    battery4.enabled = false;
                    battery5.enabled = false;
                }
                if (batteryLife > 180)
                {
                    if (batteryLife <= 270)
                    {
                        battery1.enabled = false;
                        battery2.enabled = true;
                        battery3.enabled = false;
                        battery4.enabled = false;
                        battery5.enabled = false;
                    }
                }
            }

        }


    }

}
