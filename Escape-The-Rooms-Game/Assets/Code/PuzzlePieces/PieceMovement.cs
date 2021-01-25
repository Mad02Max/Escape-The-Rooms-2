using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{

    private Rigidbody rigidPieces;
    private Transform transPieces;
    public bool moveYes;
    float speed = 1f;
    float negativeSpeed = -1f;
    public bool pickUp;
    public GameObject rotationTarget;


    public void Awake()
    {
        moveYes = false;
        pickUp = false;
    }

    private void Start()
    {
        rigidPieces = GetComponent<Rigidbody>();
        transPieces = GetComponent<Transform>();
    }

    void Update()
    {
        if (moveYes == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rigidPieces.transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rigidPieces.transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rigidPieces.transform.position = transform.position + new Vector3(0, 0, speed);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rigidPieces.transform.position = transform.position + new Vector3(0, 0, negativeSpeed);
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                transPieces.transform.RotateAround(rotationTarget.transform.position, Vector3.up, -90);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                transPieces.transform.RotateAround(rotationTarget.transform.position, Vector3.up, 90);
            }
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            Debug.Log("Collides with cursor");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space is pressed");
                if (pickUp == false)
                {
                    moveYes = !moveYes;
                }
            }
        }
    }



}
