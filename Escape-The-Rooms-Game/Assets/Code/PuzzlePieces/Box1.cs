using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//By Caleb

public class Box1 : MonoBehaviour
{
    // Max
    public Toggle pickUpPiece;

    public Toggle putDownPiece;

    public Toggle rotateLeft;

    public Toggle rotateRight;

    private bool left = false;

    private bool right = false;
    // Slut Max

    //Creating a rigidbody and a transfom in visual studio.
    //Creating a bool that will allow/hinder the pieces regarding movement.
    //Creates a float for speed for that eventual movement.
    //Creates a bool that will control the picking up/putting down of pieces
    //Creates a gameobject to use as a point for rotation.
    private Rigidbody rigidPieces;
    private Transform pieceTrans;
    public bool movePiece;
    float speed = 1f;
    float negativeSpeed = -1f;
    public bool no;
    public GameObject target;

    public bool iLuften;
    public bool grounded;
    public bool flying;

    public Rigidbody rigidbodyForCursor;

    public bool speedChanger2;

    //Connects the visual studio rigidbody and transfom to the unity ones
    //Sets the target for rotation. 
    void Start()
    {
        rigidPieces = GetComponent<Rigidbody>();
        pieceTrans = GetComponent<Transform>();
        target = GameObject.FindGameObjectWithTag("Cursor");
    }

    //Sets the bools to their starting value
    public void Awake()
    {
        movePiece = false;
        no = false;
        rigidbodyForCursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Rigidbody>();
        iLuften = false;
        grounded = true;
        flying = false;
    }

    //Makes the pieces able to move and rotate when movePiece is true
    void Update()
    {

        if (movePiece == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                pieceTrans.transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                pieceTrans.transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                pieceTrans.transform.position = transform.position + new Vector3(0, 0, speed);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                pieceTrans.transform.position = transform.position + new Vector3(0, 0, negativeSpeed);
            }

            speedChanger2 = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().speedChanger;

            if (speedChanger2 == false)
            {
                speed = 1;
                negativeSpeed = -1;
            }
            if (speedChanger2 == true)
            {
                speed = 2;
                negativeSpeed = -2;
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                pieceTrans.transform.RotateAround(target.transform.position, Vector3.up, -90);

                //left = true;
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                pieceTrans.transform.RotateAround(target.transform.position, Vector3.up, 90);

               //right = true;
            }
        }


        // = GameObject.FindGameObjectWithTag("Left").GetComponent<Toggle>();

        //rotateRight = GameObject.FindGameObjectWithTag("Right").GetComponent<Toggle>();
        /*
        if (left == true)
        {

            rotateLeft.isOn = true;

        }

        if(right == true)
        {
            rotateRight.isOn = true;
        }*/
        movePiece = flying;


        pickUpPiece = GameObject.FindGameObjectWithTag("Pick").GetComponent<Toggle>();

        putDownPiece = GameObject.FindGameObjectWithTag("Down").GetComponent<Toggle>();

    }

    //Makes it so that if the cursor is on a piece, "no" is false, and if the spacebar is pressed, the pieces will be able to move
    //The pieces are therefore "picked up" by the cursor.
    //Then they can be "dropped" by pressing space
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            if (no == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    grounded = false;

                    if (grounded == false)
                    {
                        if (iLuften == true)
                        {
                            Down();
                            movePiece = false;
                            flying = false;
                        }
                        if (iLuften == false)
                        {
                            UP();
                        }

                        //iLuften = !iLuften;
                        //movePiece = iLuften;

                    }
                }
            }

            //David did this(start)
            //GetComponent<Renderer>().material.color = new Color32(255, 255, 0, 255);
            //David did this(stop)
        }

        if (collision.gameObject.tag == "Platform")
        {
            iLuften = false;
            movePiece = false;
            flying = false;
            grounded = true;
        }
        if (collision.gameObject.tag == "Floor")
        {
            iLuften = false;
            movePiece = false;
            flying = false;
            grounded = true;
        }

    }

    //There two methods change "no" into true and false. This makes it so that block can't be placed on other blocks.
    //Should also make it so that no more than one piece can be picked up at a time, alas; it does not work.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            //Don't delete this if-statement
        }

        if (collision.gameObject.tag == "1")
        {
            no = true;
            Debug.Log("no = true");
        }
        if (collision.gameObject.tag == "2")
        {
            no = true;
            Debug.Log("no = true");
        }
        if (collision.gameObject.tag == "4")
        {
            no = true;
            Debug.Log("no = true");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "1")
        {
            no = false;
            Debug.Log("no = false");
        }
        if (collision.gameObject.tag == "2")
        {
            no = false;
            Debug.Log("no = false");
        }
        if (collision.gameObject.tag == "4")
        {
            no = false;
            Debug.Log("no = false");
        }
    }


    public void UP()
    {
        if (grounded == true)
        {
            return;
        }
        if (flying == true)
        {
            return;
        }

        rigidPieces.transform.position = transform.position + new Vector3(0, 5f, 0);
        Debug.Log("It went up");
        rigidbodyForCursor.transform.position = rigidbodyForCursor.transform.position + new Vector3(0, 5f, 0);
        iLuften = true;
        movePiece = true;
        flying = true;
        pickUpPiece.isOn = true;

    }

    public void Down()
    {
        rigidPieces.transform.position = transform.position + new Vector3(0, -5f, 0);
        Debug.Log("It went down");
        rigidbodyForCursor.transform.position = rigidbodyForCursor.transform.position + new Vector3(0, -5f, 0);
        putDownPiece.isOn = true;
    }
}
