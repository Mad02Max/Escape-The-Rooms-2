using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//By Caleb

public class Cockroch : MonoBehaviour
{
    //Connects the sounds between visual studio and unity.
    //Vreates a bool that turns the sounds on and off.
    //Creates a rng and timer, each, for how long the sound will be on and off.
    public AudioSource cockroach1;
    public AudioSource cockroach2;
    public bool on;
    public float rngOn;
    public float rngOff;
    public float timerOn;
    public float timerOff;

    //Have the sounds be off at the start
    //Starting the methods, that makes the sound random, for the first time.
    public void Awake()
    {
        on = false;
        Roller();
        Timer();
    }

    //Checks whetever "on" is true or false; and turning the sounds on and off accordingly, also starts timer for how long it will be on/off.
    //Makes it so that when a timer is under or equal to 0, the sounds turn on/off, the time is randomised, and the next timer starts.
    public void Update()
    {
        if (on == true)
        {
            cockroach1.enabled = true;
            cockroach2.enabled = true;
            timerOn = timerOn - 1 * Time.deltaTime;
        }
        if (on == false)
        {
            cockroach1.enabled = false;
            cockroach2.enabled = false;
            timerOff = timerOff - 1 * Time.deltaTime;
        }

        if (timerOn <= 0)
        {
            on = false;
            Roller();
            Timer();
        }
        if (timerOff <= 0)
        {
            on = true;
            Roller();
            Timer();
        }
    }

    //Randomises two floats.
    public void Roller()
    {
        rngOn = Random.Range(4, 8);
        rngOff = Random.Range(8, 12);
    }

    //Makes two floats the same as the random ones
    public void Timer()
    {
        timerOn = rngOn;
        timerOff = rngOff;
    }
}
