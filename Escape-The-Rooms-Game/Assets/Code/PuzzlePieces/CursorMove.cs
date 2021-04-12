using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//All done by Caleb

public class CursorMove : MonoBehaviour
{

    //Max

    public Toggle moveWASD;

    public bool w = false;
    public bool a = false;
    public bool s = false;
    public bool d = false;

    // End Max

    //Creates a rigidbody in visual studio.
    //Creates an int for the speed of the cursor.
    private Rigidbody rigidCur;
    float speed = 1f;
    float negativeSpeed = -1f;

    public bool speedChanger;

    //Connects the visual studio rigidbody to the unity rigidbody.
    void Start()
    {
        rigidCur = GetComponent<Rigidbody>();
        speedChanger = false;
    }

    //Makes the character able to move.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidCur.transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
            a = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidCur.transform.position = transform.position + new Vector3(speed, 0, 0);
            d = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidCur.transform.position = transform.position + new Vector3(0, 0, speed);
            w = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidCur.transform.position = transform.position + new Vector3(0, 0, negativeSpeed);
            s = true;
        }

        if(w == true && a == true && s == true && d == true)
        {
            moveWASD.isOn = true;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            speedChanger = !speedChanger;
        }
        if (speedChanger == false)
        {
            speed = 1;
            negativeSpeed = -1;
        }
        if (speedChanger == true)
        {
            speed = 2;
            negativeSpeed = -2;
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
