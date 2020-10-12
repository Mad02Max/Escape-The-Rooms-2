using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    //We are setting a speed to easier 
    public float speed = 3f;

    public float negativSpeed = -3f;
    private Rigidbody rb3d;



    // Start is called before the first frame update
    void Start()
    {
        rb3d = GetComponent <Rigidbody>();
    }
 

    // Update is called once per frame
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
