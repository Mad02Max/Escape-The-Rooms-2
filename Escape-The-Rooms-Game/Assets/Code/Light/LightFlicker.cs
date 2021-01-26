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
    public bool on;
    public Light spot;
    public float rng;
    public float timer;
    public bool scriptWork;

    //These were made just because I was bored, they can change the colour of the light, at random.
    public float r;
    public float g;
    public float b;
    public float rc;
    public float gc;
    public float bc;

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

    public void Update()
    {
        if (scriptWork == true)
        {
            if (on == false)
            {
                spot.enabled = false;
            }
            if (on == true)
            {
                spot.enabled = true;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                on = !on;
            }

            //CALEB!!!! GÖR SÅ ATT DEN SÄTTER PÅ SNABBARE, VÄNLIGA HÄLSNINGAR; DIG SJÄLV


            timer = timer - 1 * Time.deltaTime;
            if (timer <= 0)
            {
                on = !on;
                spot.color = new Vector4(rc, gc, bc);
                Roller2();
                Roller();
                Timer();
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            scriptWork = !scriptWork;
        }




    }

    public void Roller()
    {
        rng = Random.Range(0.5f, 3);
    }

    public void Timer()
    {
        timer = rng;
    }
    
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
