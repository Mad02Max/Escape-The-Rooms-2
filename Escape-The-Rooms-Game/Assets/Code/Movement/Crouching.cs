using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouching : MonoBehaviour
{
    public bool crouch;

    void Start()
    {
        crouch = true;
    }


    void Update()
    { 
        if (crouch == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                transform.position = transform.position + new Vector3(0, -20, 0);
                crouch = false;
            }
        }
        if (crouch == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                transform.position = transform.position + new Vector3(0, 20, 0);
                crouch = true;
            }
        }
    }
}
