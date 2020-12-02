using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidCur.transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidCur.transform.position = transform.position + new Vector3(speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidCur.transform.position = transform.position + new Vector3(0, 0, speed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigidCur.transform.position = transform.position + new Vector3(0, 0, negativeSpeed);
        }
    }

    //Freezes the cursor's rigidbody constraints when it touches the playboard.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            rigidCur.constraints = RigidbodyConstraints.FreezeAll;
        }
    }


}
