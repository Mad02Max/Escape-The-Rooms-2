using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1 : MonoBehaviour
{
    private Rigidbody rigidPieces;
    public bool movePiece;
    float speed = 1f;
    float negativeSpeed = -1f;
    public int moveTest = 0;



    // Start is called before the first frame update
    void Start()
    {
        rigidPieces = GetComponent<Rigidbody>();
    }

    public void Awake()
    {
        movePiece = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (movePiece == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, speed);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, negativeSpeed);
            }


            

        }




    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Cursor")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                movePiece = true;
                moveTest++;
            }
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                movePiece = true;
                moveTest++;
            }
        }
    }


}
