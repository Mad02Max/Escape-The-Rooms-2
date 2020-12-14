using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Made by Caleb

public class Timer : MonoBehaviour
{
    //Creates a float that is a timer.
    //Time definer decides the timer randomly.
    //A text that displace the timer.
    public float timer;
    public int timeDefiner;
    public Text timerText;

    //time definer is randomly decided, and timer is decided as such.
    void Start()
    {
        timeDefiner = Random.Range(1, 101);

        if (timeDefiner == 1)
        {
            timer = 300;
        }
        if (timeDefiner == 100)
        {
            timer = 3600;
        }
        if (timeDefiner >= 2)
        {
            if (timeDefiner <= 31)
            {
                timer = 600;
            }
            if (timeDefiner >= 32)
            {
                if (timeDefiner <= 81)
                {
                    timer = 900;
                }
                if (timeDefiner >= 82)
                {
                    if (timeDefiner <= 99)
                    {
                        timer = 1800;
                    }
                }
            }
        }

        
    }

    //The timer counts down
    void Update()
    {
        timer = timer - 1 * Time.deltaTime;
        timerText.text = "timer = " + timer;

    }
}
