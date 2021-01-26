﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public bool on;
    public Light spot;
    public int rng;
    public float timer;
    public int timerReal;
    
    public float r;
    public float g;
    public float b;
    public float rc;
    public float gc;
    public float bc;

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
            //Color newColor = new Vector4(rc, gc, bc);
            spot.color = new Vector4(rc, gc, bc);
            Roller2();
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