using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CammeraSwitching : MonoBehaviour
{
    bool FirstPersoneCam;
    bool PuzzleCamra;
    public Camera charCam;
    public Camera puzzCam;


    void Start()
    {
        FirstPersoneCam = true;
        PuzzleCamra = false;
    }


    void Update()
    {
        if (FirstPersoneCam == true)
        {
            charCam.enabled = true;
            puzzCam.enabled = false;

            if (Input.GetKey(KeyCode.C))
            {
                FirstPersoneCam = false;
                PuzzleCamra = true;
                GetComponent<Movement>().moveYes = false;
                GetComponent<Box1>().movePiece = true;
            }
        }

        if (PuzzleCamra == true)
        {
            charCam.enabled = false;
            puzzCam.enabled = true;

            if (Input.GetKey(KeyCode.C))
            {
                FirstPersoneCam = true;
                PuzzleCamra = false;
                GetComponent<Movement>().moveYes = true;
                GetComponent<Box1>().movePiece = false;
            }
        }        
    }
}
