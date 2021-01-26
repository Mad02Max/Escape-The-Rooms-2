using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public bool on;
    public Light spot;
    public int rng;
    public float timer;
    public int timerReal;

    public void Awake()
    {
        on = true;
        spot = GetComponent<Light>();
        Roller();
        Timer();
    }

    public void Update()
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




        timer = timer - 1 * Time.deltaTime;
        if (timer <= 0)
        {
            on = !on;
            Roller();
            Timer();
        }
    }

    public void Roller()
    {
        rng = Random.Range(1, 4);
    }

    public void Timer()
    {
        timer = rng;
        
    }

}
