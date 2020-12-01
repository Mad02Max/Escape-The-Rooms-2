using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1 : MonoBehaviour
{
    private Rigidbody rigidPieces;
    private Transform pieceTrans;
    public bool movePiece;    
    float speed = 1f;
    float negativeSpeed = -1f;
    public int moveTest = 0;
    public bool space;
    private Renderer re;



    // Start is called before the first frame update
    void Start()
    {
        rigidPieces = GetComponent<Rigidbody>();
        pieceTrans = GetComponent<Transform>();
        //re = GetComponent<Renderer>();
        //re.material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
    }

    public void Awake()
    {
        movePiece = false;
        space = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movePiece == true)
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
                pieceTrans.transform.Rotate(0, -90, 0);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                pieceTrans.transform.Rotate(0, 90, 0);
            }
        }




    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            /*if (space == true)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    movePiece = true;
                    moveTest++;
                    space = false;
                }
            }*/
            if (Input.GetKey(KeyCode.Space))
            {
                movePiece = true;
                moveTest++;
                space = false;
            }
            if (Input.GetKey(KeyCode.RightShift))
            {
                movePiece = false;
                moveTest++;
                space = false;
            }

            
        }

        if (collision.gameObject.tag == "Cursor" )
        {
            if (collision.gameObject.tag == "4")
            {
                if (Input.GetKey(KeyCode.RightShift))
                {
                    movePiece = true;
                    moveTest++;
                    space = false;
                }
            }
        }



    }




    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                movePiece = true;
                moveTest++;
            }
        }
    }*/


}
