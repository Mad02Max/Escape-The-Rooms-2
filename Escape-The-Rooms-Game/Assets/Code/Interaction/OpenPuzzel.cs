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

            //Gjord av Caleb
            //Gör så att man bara kan röra karaktären, kameran och pussel cursor när man ska kunna
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().moveYes = false;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().lookYes = false;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().cursorYes = true;
            //Slutet av gjort av Caleb
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                characterCam.enabled = true;

                puzzleCam.enabled = false;

                //Gjord av Caleb
                //Gör så att man bara kan röra karaktären, kameran och pussel cursor när man ska kunna
                GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().moveYes = true;
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().lookYes = true;
                GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().cursorYes = false;
                //Slutet av gjort av Caleb
            }
        }

    }
}
