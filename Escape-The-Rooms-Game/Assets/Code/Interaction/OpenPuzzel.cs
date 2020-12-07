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

            //GetComponent<Movement>().moveYes = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().moveYes = false;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().cursorYes = true;


            //player.SetActive(false);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                characterCam.enabled = true;

                puzzleCam.enabled = false;

                //GetComponent<Movement>().moveYes = true;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().moveYes = true;
                GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().cursorYes = false;

                //player.SetActive(false);
            }
        }

    }
}
