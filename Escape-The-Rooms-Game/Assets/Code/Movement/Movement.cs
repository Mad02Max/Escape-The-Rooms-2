using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//All done by Caleb
namespace VHS
{


public class Movement : MonoBehaviour
{
    //We are setting a speed to more easily change it if needed. We are also setting a reverse speed for the same reason.
    public float speed = 1000f;
    public float negativSpeed = -1000f;
    
    //We are making the rigidbody a objekt to use it.
    private Rigidbody rb3d;

    //Makes it so that the player can't move when in the puzzle camera
    public bool moveYes;

    
    //We are doing so the rigidbody objekt in visual studio is interacting with the rigidbody of the unity objekt.
    void Start()
    {
        
        rb3d = GetComponent <Rigidbody>();
        
    }

    //Sets the bool deciding if movement is possible as true right when the game starts
    public void Awake()
    {
        moveYes = true;
    }
 

    //We are using "AddForce" to change the possition of the player. 
    //Here we are using "speed" and "negativeSpeed".
    //"Time.deltaTime" makes it so that the speed is the same across diffrent computers.
    //We are using "transform.rotation" to make it so that the character is moving in relation to the direction one is looking.
    //"moveYes" makes is there so that you are only able to move when it is true. That is because it is turned off when the camera is-
    //-switched to the puzzle camera, as you shouldn't be able to move then
    void Update()
    {
        if (moveYes == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb3d.AddForce(transform.rotation * Vector3.forward * speed * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.A))
            {
                rb3d.AddForce(transform.rotation * Vector3.left * speed * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.S))
            {
                rb3d.AddForce(transform.rotation * Vector3.back * speed * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.D))
            {
                rb3d.AddForce(transform.rotation * Vector3.right * speed * Time.deltaTime);

            }
        }

    }
}
}
