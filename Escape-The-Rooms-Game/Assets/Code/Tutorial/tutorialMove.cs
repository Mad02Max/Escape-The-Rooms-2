using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialMove : MonoBehaviour
{

    public Toggle move;

    public Toggle flashlight;

    public GameObject pickUpTutorial;
   


    // Update is called once per frame
    void Update()
    {

        if (move.isOn == true && flashlight.isOn == true)
        {
            pickUpTutorial.SetActive(true);

            Destroy(gameObject);
        }

    }

}
