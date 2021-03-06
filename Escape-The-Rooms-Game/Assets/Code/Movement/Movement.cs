﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//All done by Caleb

public class Movement : MonoBehaviour
{
    //We are setting a speed to more easily change it if needed. We are also setting a reverse speed for the same reason.
    public float speed = 5000000f;
    public float negativSpeed = -5000000f;
    
    //We are making the rigidbody a objekt to use it.
    private Rigidbody rb3d;

    //Makes it so that the player can't move when in the puzzle camera
    public bool moveYes;

    public bool crouch;

    //This will show the players cordinates, it is here for testing reasons
    public Text Position;

    public bool w = false;

    public bool s = false;

    public bool d = false;

    public bool a = false;

    public Toggle WASD;

    //We are doing so the rigidbody objekt in visual studio is interacting with the rigidbody of the unity objekt.
    void Start()
    {        
        rb3d = GetComponent <Rigidbody>(); 
    }

    //Sets the bool deciding if movement is possible as true right when the game starts
    public void Awake()
    {
        moveYes = true;
        crouch = false;

    } 

    //We are using "AddForce" to change the possition of the player. 
    //Here we are using "speed" and "negativeSpeed".
    //"Time.deltaTime" makes it so that the speed is the same across diffrent computers.
    //We are using "transform.rotation" to make it so that the character is moving in relation to the direction one is looking.
    //"moveYes" makes is there so that you are only able to move when it is true. That is because it is turned off when the camera is-
    //-switched to the puzzle camera, as you shouldn't be able to move then
    //There is lines of codes that makes it so that the console/log shows when a button is pressed.
    void Update()
    {
        if (moveYes == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb3d.AddForce(transform.rotation * Vector3.forward * speed * Time.deltaTime);
                //Debug.Log("W is pressed");

                w = true;
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb3d.AddForce(transform.rotation * Vector3.left * speed * Time.deltaTime);
                //Debug.Log("A is pressed");

                a = true;
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb3d.AddForce(transform.rotation * Vector3.back * speed * Time.deltaTime);
                //Debug.Log("S is pressed");

                s = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb3d.AddForce(transform.rotation * Vector3.right * speed * Time.deltaTime);
                //Debug.Log("D is pressed");

                d = true;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                crouch = !crouch;
                if (crouch == true)
                {
                    rb3d.transform.localScale = rb3d.transform.localScale + new Vector3(0, -5, 0);
                    rb3d.transform.position = rb3d.transform.position + new Vector3(0, -10, 0);
                }
                if (crouch == false)
                {
                    rb3d.transform.localScale = rb3d.transform.localScale + new Vector3(0, 5, 0);
                    rb3d.transform.position = rb3d.transform.position + new Vector3(0, 10, 0);

                }
            }

            if(w == true && s == true && a == true && d == true)
            {
                WASD.isOn = true;
            }
            
        }

        //Text telling player cordinate
        Position.text = "position is " + transform.position;

        

    }
}
