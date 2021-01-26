using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAround : MonoBehaviour
{

    // speed of mouse
    public float mouseSensitivity = 400f;
    public Text mS;


    // Make camera moving
    public Transform playerBody;

    // So it follows the x axis
    float xRotation = 0f;

    //A bool deciding if you can look around (gjord av Caleb)
    public bool lookYes;

    


    /*float AngleAddition(float value)
    {
        float angle = value + 90;
        return angle;
    }*/

    



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Makes it so that you can look around when the game starts(gjord av Caleb).
    public void Awake()
    {
        lookYes = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (lookYes == true)
        {
            // Get input from mouse
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            // Make you look up and down

            xRotation -= mouseY;

            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            // So it turns around
            playerBody.Rotate(Vector3.up * mouseX);
        }



        if (Input.GetKeyDown(KeyCode.N))
        {
            mouseSensitivity = mouseSensitivity - 10;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mouseSensitivity = mouseSensitivity + 10;
        }



        mS.text = "mouse sensitivity = " + mouseSensitivity;
    }
}
