using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Caleb

public class Crouching : MonoBehaviour
{
    //This Camera is to acces the camera that will make the crouching work.
    public Camera crouchCam;

    //Starts the crouching camera as disabled.
    private void Awake()
    {
        crouchCam.enabled = false;
    }

    //Changes between normal camera and crouching camera when "C" is pressed.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Camera>().enabled;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
        }
    }

}
