using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    //We are setting a speed to more easily change it if needed. We are also setting a reverse speed for the same reason.
    public float speed = 3f;
    public float negativSpeed = -3f;
    
    //We are making the rigidbody a objekt to use it.
    private Rigidbody rb3d;



    
    //We are doing so the rigidbody objekt in visual studio is interacting with the rigidbody of the unity objekt.
    void Start()
    {
        rb3d = GetComponent <Rigidbody>();
    }
 

    //We are using "AddForce" to change the possition of the player. 
    //Here we are using "speed" and "negativeSpeed".
    //"Time.deltaTime" makes it so that the speed is the same across diffrent computers.
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb3d.AddForce(new Vector3(0, 0, speed) * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.S))
        {
            rb3d.AddForce(new Vector3(0, 0, negativSpeed) * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.D))
        {
            rb3d.AddForce(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb3d.AddForce(new Vector3(negativSpeed, 0, 0) * Time.deltaTime);
        }
        



    }
}
