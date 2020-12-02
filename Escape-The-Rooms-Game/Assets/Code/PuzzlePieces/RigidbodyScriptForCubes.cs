using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All done by Caleb

public class RigidbodyScriptForCubes : MonoBehaviour
{
    //We are making the rigidbody a objekt to use it.
    private Rigidbody rb3dn2;

    //We are doing so the rigidbody objekt in visual studio is interacting with the rigidbody of the unity objekt.
    void Start()
    {
        rb3dn2 = GetComponent<Rigidbody>();
    }

    //We are doing so that the tetris pieces can't move once they are on the platform.
    //Or on the game board.
    //We do this by freezing all the rigidbody constraints, so that the objects won't move or rotate. 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            rb3dn2.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (collision.gameObject.tag == "Platform")
        {
            rb3dn2.constraints = RigidbodyConstraints.FreezeAll;
        }
    }




}
