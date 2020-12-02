using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//All done by Caleb

public class Timer : MonoBehaviour
{
    //Starts the timer when the game starts. 
    void Start()
    {
        StartCoroutine(Waiter());
    }

    //This is the timer
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(600);
        Destroy(gameObject);

    }

}
