using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
<<<<<<< HEAD

    // speed of mouse
    public float mouseSensitivity = 200f;
=======
    public float mouseSensitivity = 100f;
>>>>>>> parent of 0573e33... Look Around

    public Transform playerBody;
<<<<<<< HEAD

    // So it follows the x axis
    float xRotation = 0f;
=======
>>>>>>> parent of 0573e33... Look Around
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

    }
}
