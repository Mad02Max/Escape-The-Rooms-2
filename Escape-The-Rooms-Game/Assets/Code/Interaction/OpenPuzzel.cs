using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class OpenPuzzel : InteractableBase
    {
        public Camera characterCam;
        public Camera puzzleCam;

        //public Movement movement;

        // Start is called before the first frame update
        void Awake()
        {
            characterCam.enabled = true;

            puzzleCam.enabled = false;
        }
        public override void OnInteract()
        {
            base.OnInteract();

            characterCam.enabled = false;

            puzzleCam.enabled = true;

            //movement.moveYes = false;

            //player.SetActive(false);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                characterCam.enabled = true;

                puzzleCam.enabled = false;

                //movement.moveYes = true;

                //player.SetActive(false);
            }
        }

    }
}
