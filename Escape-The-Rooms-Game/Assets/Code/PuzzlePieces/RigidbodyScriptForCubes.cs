using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyScriptForCubes : MonoBehaviour
{

    private Rigidbody rb3dn2;



    // Start is called before the first frame update
    void Start()
    {
        rb3dn2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            rb3dn2.constraints = RigidbodyConstraints.FreezeAll;
        }
    }




}
