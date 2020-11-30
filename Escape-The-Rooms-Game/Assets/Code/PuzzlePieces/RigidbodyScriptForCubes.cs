using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All done by Caleb

public class RigidbodyScriptForCubes : MonoBehaviour
{
    //We are making the rigidbody a objekt to use it.
    private Rigidbody rb3dn2;



    //Start is called before the first frame update
    //We are doing so the rigidbody objekt in visual studio is interacting with the rigidbody of the unity objekt.
    void Start()
    {
        rb3dn2 = GetComponent<Rigidbody>();
    }

    //Update is called once per frame
    void Update()
    {
        
    }

    //We are doing so that the tetris pieces can't move once they are on the platform.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            rb3dn2.constraints = RigidbodyConstraints.FreezeAll;
            rb3dn2.isKinematic = true;
        }
    }




}
