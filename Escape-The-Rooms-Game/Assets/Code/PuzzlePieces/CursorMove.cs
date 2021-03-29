﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All done by Caleb

public class CursorMove : MonoBehaviour
{
    //Creates a rigidbody in visual studio.
    //Creates an int for the speed of the cursor.
    private Rigidbody rigidCur;
    float speed = 1f;
    float negativeSpeed = -1f;

    //Connects the visual studio rigidbody to the unity rigidbody.
    void Start()
    {
        rigidCur = GetComponent<Rigidbody>();        
    }

    //Makes the character able to move.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidCur.transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidCur.transform.position = transform.position + new Vector3(speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidCur.transform.position = transform.position + new Vector3(0, 0, speed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidCur.transform.position = transform.position + new Vector3(0, 0, negativeSpeed);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            rigidCur.transform.position = rigidCur.transform.position + new Vector3(0, 5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            rigidCur.transform.position = rigidCur.transform.position + new Vector3(0, -5f, 0);
        }
    }

    //Freezes the cursor's rigidbody constraints when it touches the playboard, or the "table".
    //Since the cursor starts in the air and falls, this makes it so that it's position will be exactly as needed.
    //Also starts the waiter method, which will turn of the script till further input.
    void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "Platform")
        {
            rigidCur.constraints = RigidbodyConstraints.FreezeAll;
            StartCoroutine(Waiter());
        }
        if (collision.gameObject.tag == "Floor")
        {
            rigidCur.constraints = RigidbodyConstraints.FreezeAll;
            StartCoroutine(Waiter());
        }*/
    }

    //Makes it so that the script is disabled 1 sec after start, this makes everything work later
    /*IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);
        GetComponent<CursorMove>().enabled = false;
    }*/


}
