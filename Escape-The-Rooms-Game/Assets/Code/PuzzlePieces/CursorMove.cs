using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMove : MonoBehaviour
{
    private Rigidbody rigidCur;
    //public bool movePiece;
    float speed = 1f;
    float negativeSpeed = -1f;



    // Start is called before the first frame update
    void Start()
    {
        rigidCur = GetComponent<Rigidbody>();
    }

    public void Awake()
    {
        //movePiece = false;
    }

    // Update is called once per frame
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

        /*if (movePiece == true)
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
        }*/
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            rigidCur.constraints = RigidbodyConstraints.FreezeAll;
            rigidCur.isKinematic = true;
        }
    }


}
