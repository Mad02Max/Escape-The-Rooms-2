using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePieces : MonoBehaviour
{
    private Rigidbody rigidPieces;
    public bool movePiece;
    float speed = 0.08f;
    float negativeSpeed = 0.08f;



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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(negativeSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, -10);
        }

        /*if (movePiece == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector4(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector4(1, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector4(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector4(0, 0, -1);
            }




        }*/
    }
}
