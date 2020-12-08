using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//All done by Caleb

public class Timer : MonoBehaviour
{
    //Starts the timer when the game starts.
    public int timer;
    public int timerDecider;
    void Start()
    {
        timerDecider = Random.Range(1, 101);
        if (timerDecider == 1)
        {
            timer = 300;
        }
        if (timerDecider == 100)
        {
            timer = 3600;
        }
        if (timerDecider >= 2)
        {
            if (timerDecider <= 51)
            {
                timer = 600;
            }
            if (timerDecider >= 52)
            {
                if (timerDecider <= 76)
                {
                    timer = 900;
                }
                if (timerDecider >= 77)
                {
                    if (timerDecider <= 99)
                    {
                        timer = 1800;
                    }
                }
            }
            
        }

        StartCoroutine(Waiter());
    }

    //This is the timer
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }

}
