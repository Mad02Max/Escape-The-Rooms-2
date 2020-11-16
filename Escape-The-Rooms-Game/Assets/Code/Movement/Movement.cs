using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//All done by Caleb

public class Movement : MonoBehaviour
{
    //We are setting a speed to more easily change it if needed. We are also setting a reverse speed for the same reason.
    public float speed = 1000f;
    public float negativSpeed = -1000f;
    
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
    //We are using "transform.rotation" to make it so that the character is moving in relation to the direction one is looking.
    void Update()
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
