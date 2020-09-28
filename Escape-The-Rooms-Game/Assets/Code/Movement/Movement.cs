using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    float speed = 3f;
    private Rigidbody rb3d;



    // Start is called before the first frame update
    void Start()
    {
        rb3d = GetComponent <Rigidbody>();

    }
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb3d.AddForce(new Vector3(0, 0, 250));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb3d.AddForce(new Vector3(0, 0, -250));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb3d.AddForce(new Vector3(0, 0, -250));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb3d.AddForce(new Vector3(0, 0, 250));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb3d.AddForce(new Vector3(250, 0, 0));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb3d.AddForce(new Vector3(-250, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb3d.AddForce(new Vector3(-250, 0, 0));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb3d.AddForce(new Vector3(250, 0, 0));
        }



    }
}
