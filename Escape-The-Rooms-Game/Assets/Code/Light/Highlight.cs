using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Light rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "Cursor")
        {
            Debug.Log("they collide");
            rend.color = new Vector4(255, 105, 180);
        }*/
        if (collision.gameObject.tag == "Cursor")
        {
            rend.enabled = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        /*if (collision.gameObject.tag == "Cursor")
        {
            Debug.Log("they collide");
            rend.color = new Vector4(255, 105, 180);
        }*/
        if (collision.gameObject.tag == "Cursor")
        {
            rend.enabled = false;
        }
    }

}
