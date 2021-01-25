using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All done by Caleb

public class CursorMove : MonoBehaviour
{
    //Creates a rigidbody in visual studio.
    //Creates an int for the speed of the cursor.
    //Creates a bool so that the cursor only can move when intended.
    private Rigidbody rigidCur;
    float speed = 1f;
    float negativeSpeed = -1f;
    //public bool cursorYes;

    //Connects the visual studio rigidbody to the unity rigidbody.
    //Starts the method "Waiter".
    void Start()
    {
        rigidCur = GetComponent<Rigidbody>();        
    }

    //Makes it so that you can't move the cursor(pink bo) unless in the pussle
    public void Awake()
    {
        //cursorYes = false;
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
            StartCoroutine(Waiter());
        }
        if (collision.gameObject.tag == "Floor")
        {
            rigidCur.constraints = RigidbodyConstraints.FreezeAll;
            StartCoroutine(Waiter());
        }
    }

    //Makes it so that the script is disabled 3 sec after start, this makes everything work later
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);
        GetComponent<CursorMove>().enabled = false;
    }


}
