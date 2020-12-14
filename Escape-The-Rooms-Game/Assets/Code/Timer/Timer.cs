using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//All done by Caleb

public class Timer : MonoBehaviour
{
    //A float for the timer so that it can be counted and showed properly.
    //TimerText is the text that shows the timer.
    //TimerDecider is the int that is randomised, then chooses the lenght of the timer.
    public float timer;
    public Text timertext;
    public int timerDecider;

    //After entering the game(past the main menu) the int "timerDecider" is randomised between 1 and 100
    //Depending on the number that is choosen, the float "timer" is different
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
    }

    //In void update, I make it so that the timer is lowered by one second,I do this by using -1*Time.deltaTime
    //That makes it so that the time that is removed from the timer is always one second.
    //When the timer is at 0, the scene is switched and the cursor is activated.
    void Update()
    {
        timer = timer - 1 * Time.deltaTime;
        timertext.text = "timer = " + timer;

        if (timer <= 0)
        {
            SceneManager.LoadScene(sceneName: "GameOver");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
