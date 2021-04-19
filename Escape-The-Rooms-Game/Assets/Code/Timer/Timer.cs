using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Made by Caleb

public class Timer : MonoBehaviour
{
    //Creates a float that is a timer.
    //Time definer decides the timer randomly.
    //A text that displace the timer.
    public float timer;
    public int timeDefiner;
    public Text timerText;

    public Slider timerSlider;

    public AudioSource Violin;

    //Time definer is randomly decided, and timer is decided as such.
    void Start()
    {
        Violin.enabled = false;

        timeDefiner = Random.Range(1, 101);

        if (timeDefiner == 1)
        {
            timer = 100;
        }
        if (timeDefiner == 100)
        {
            timer = 100;
        }
        if (timeDefiner >= 2)
        {
            if (timeDefiner <= 31)
            {
                timer = 100;
            }
            if (timeDefiner >= 32)
            {
                if (timeDefiner <= 81)
                {
                    timer = 100;
                }
                if (timeDefiner >= 82)
                {
                    if (timeDefiner <= 99)
                    {
                        timer = 100;
                    }
                }
            }
        }

        timerSlider.maxValue = timer;
    }

    //The timer counts down
    //Shows the timer
    //Makes the scene change to game over once timer is equal or lower than 0. Also unlocks the cursor.
    //Instant death button, for testing
    void Update()
    {
        timer = timer - 1 * Time.deltaTime;
        timerText.text = "timer = " + timer;

        if (timer <= 0)
        {
            SceneManager.LoadScene(sceneName: "GameOver");
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            timer = 0;
        }
        
        
        timerSlider.value = timer;

        if (timer <= 90)
        {
            Violin.enabled = true;
        }


    }
}
