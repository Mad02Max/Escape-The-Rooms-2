﻿using System.Collections;
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
    public bool no;
    public GameObject target;


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
        no = false;
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
                pieceTrans.transform.RotateAround(target.transform.position, Vector3.up, -90);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                pieceTrans.transform.RotateAround(target.transform.position, Vector3.up, 90);
            }
        }




    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            
            if (no == false)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    movePiece = true;
                    moveTest++;
                    space = false;
                }
            }
            if (Input.GetKey(KeyCode.RightShift))
            {
                if (no == false)
                {
                    movePiece = false;
                    moveTest++;
                    space = false;
                }
            }

            GetComponent<Renderer>().material.color = new Color32(255, 255, 0, 255);

        }
        

        
    }
    private void OnCollisionEnter(Collision collision)
    {
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
        if (collision.gameObject.tag == "3")
        {
            no = true;
            Debug.Log("no = true");
        }
        if (collision.gameObject.tag == "4")
        {
            no = true;
            Debug.Log("no = true");
        }
        if (collision.gameObject.tag == "5")
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
        if (collision.gameObject.tag == "3")
        {
            no = false;
            Debug.Log("no = false");
        }
        if (collision.gameObject.tag == "4")
        {
            no = false;
            Debug.Log("no = false");
        }
        if (collision.gameObject.tag == "5")
        {
            no = false;
            Debug.Log("no = false");
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
