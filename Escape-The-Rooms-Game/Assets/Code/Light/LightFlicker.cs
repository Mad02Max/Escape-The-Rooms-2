using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By Caleb

public class LightFlicker : MonoBehaviour
{
    //There is a bool created, for turning the lights on and off.
    //The actual light, but as a visual studio object.
    //A random number generator, to change the intervals of light being on and off.
    //A timer that aids in the above reason
    //Creates a minimum(start), and maximum(end) for what the rng value can be,
    public bool on;
    public Light spot;
    public float rngOn;
    public float rngOff;
    public float timerOn;
    public float timerOff;
    public float startOn = 1f;
    public float endOn = 20f;
    public float startOff = 1f;
    public float endOff = 20f;

    //This was just for testing, turning the flickering on/off.
    public bool scriptWork;

    //These were made just because I was bored, they can change the colour of the light, at random.
    public float r;
    public float g;
    public float b;
    public float rc;
    public float gc;
    public float bc;

    public float minIntensity = 1f;
    public float maxIntensity = 2.5f;
    

    //In awake, the light is turned on, the visual studio light is connected to the unity light.
    //and the two methods controlling the random flickering is activated for the first time.
    public void Awake()
    {
        scriptWork = true;
        on = true;
        spot = GetComponent<Light>();
        Roller();
        Timer();
    }

    //Here it checks if "on" is true or false, depending on what it is; the light is the same.
    //Below it lowers the timer between the flickering, and once that timer is 0, it switches "on" to the opposite of what it is,
    //It also starts the two methods, which changes the timing, and starts the timer.
    //It also currently changes colour, but that was just because I was bored.
    public void Update()
    {
        if (scriptWork == true)
        {
            if (on == false)
            {
                //spot.enabled = false;
                //spot.intensity = 1f;
                spot.intensity = spot.intensity - Time.deltaTime;
                timerOff = timerOff - 1 * Time.deltaTime;
            }
            if (on == true)
            {
                //spot.enabled = true;
                //spot.intensity = 2.5f;
                spot.intensity = spot.intensity + Time.deltaTime;

                timerOn = timerOn - 1 * Time.deltaTime;
            }

            if (timerOn <= 0)
            {
                TimerEnd();
                //spot.color = new Vector4(rc, gc, bc);
                //Roller2();
                Roller();
                Timer();
            }
            if (timerOff <= 0)
            {
                TimerEnd();
                //spot.color = new Vector4(rc, gc, bc);
                //Roller2();
                Roller();
                Timer();
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            scriptWork = !scriptWork;
        }

        if (spot.intensity > maxIntensity)
        {
            spot.intensity = maxIntensity;
        }

        if (spot.intensity < minIntensity)
        {
            spot.intensity = minIntensity;
        }
    }

    //Randomise rng.
    public void Roller()
    {
        rngOn = Random.Range(startOn, endOn);
        rngOff = Random.Range(startOff, endOff);
    }

    //Makes timer equal to rng
    public void Timer()
    {
        timerOn = rngOn;
        timerOff = rngOff;
    }
    
    public void TimerEnd()
    {
        on = !on;
    }

    //This is the thing that makes the colour random
    public void Roller2()
    {
        r = Random.Range(1, 256);
        g = Random.Range(1, 256);
        b = Random.Range(1, 256);
        rc = r / 255f;
        gc = g / 255f;
        bc = b / 255f;
    }
}
