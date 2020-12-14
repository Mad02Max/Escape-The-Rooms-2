using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Caleb

public class Crouching : MonoBehaviour
{
    //This bool is here to make it so that the player is only able to crouch a specifik amount.
    public bool crouch;

    void Start()
    {
        crouch = true;
    }

    //The actual crouching.
    //The crouching is done by lowering the possition of the camera. 
    void Update()
    { 
        if (crouch == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                transform.position = transform.position + new Vector3(0, -20, 0);
                crouch = false;
            }
        }
        if (crouch == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                transform.position = transform.position + new Vector3(0, 20, 0);
                crouch = true;
            }
        }
    }
}
