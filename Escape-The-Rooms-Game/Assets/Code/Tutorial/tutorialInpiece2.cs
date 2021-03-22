using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorialInpiece2 : MonoBehaviour
{

    public Toggle rotateL;

    public Toggle rotateR;

    public GameObject tutorialBackground;
    
    // Update is called once per frame
    void Update()
    {
        
        if(rotateL.isOn == true && rotateR.isOn == true)
        {
            Destroy(tutorialBackground);
        }

    }
}
