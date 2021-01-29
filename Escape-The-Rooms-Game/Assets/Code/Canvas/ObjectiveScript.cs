using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//By Caleb

public class ObjectiveScript : MonoBehaviour
{
    //Connects text to unity.
    public Text objectiveText;

    //Starts timer.
    public void Start()
    {
        StartCoroutine(Waiter());
    }

    //Destroy text after timer.
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(30);
        Destroy(gameObject);
    }



}
