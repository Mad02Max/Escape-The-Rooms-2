using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class OpenPuzzel : InteractableBase
    {
        bool FirstPersoneCam;
        bool PuzzleCamra;
        public Camera charCam;
        public Camera puzzCam;


        // Start is called before the first frame update
        void Awake()
        {
            FirstPersoneCam = true;
            PuzzleCamra = false;
        }
        public override void OnInteract()
        {
            base.OnInteract();


            if (FirstPersoneCam == true)
            {
                charCam.enabled = true;
                puzzCam.enabled = false;

                if (Input.GetKey(KeyCode.C))
                {
                    FirstPersoneCam = false;
                    PuzzleCamra = true;
                    GetComponent<Movement>().moveYes = false;
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
                }
            }


        }

    }
}
