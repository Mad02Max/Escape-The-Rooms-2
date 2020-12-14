using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Max and Caleb

namespace VHS
{
    public class OpenPuzzel : InteractableBase
    {
        //Creates cameras
        public Camera characterCam;
        public Camera puzzleCam;

        public GameObject interactionUI;

        public GameObject crosshair;

        //Sets the cameras to what they should start as.
        void Awake()
        {
            characterCam.enabled = true;
            puzzleCam.enabled = false;

            crosshair.SetActive(true);

            interactionUI.SetActive(true);

        }

        //Uses the interaction script so that everything happenes when you are looking at the puzzle and pressing "E".
        //Switches the cameras and turn on and off different scripts so that they are active when they should.
        public override void OnInteract()
        {

            base.OnInteract();

            characterCam.enabled = false;

            puzzleCam.enabled = true;


            //GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
            //GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;


            //Gjord av Caleb
            //Gör så att man bara kan röra karaktären, kameran, pussel cursor, pussel bitar, och "croucha" när man ska kunna
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = false;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = false;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = false;
            GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled = false;
            GameObject.FindGameObjectWithTag("1").GetComponent<Box1>().enabled = false;
            GameObject.FindGameObjectWithTag("2").GetComponent<Box1>().enabled = false;
            GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled = false;
            //Slutet av gjort av Caleb

            crosshair.SetActive(false);

            interactionUI.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                characterCam.enabled = true;

                puzzleCam.enabled = false;

                GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = true;
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = true;
                GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = true;
                GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled = true;
                GameObject.FindGameObjectWithTag("1").GetComponent<Box1>().enabled = true;
                GameObject.FindGameObjectWithTag("2").GetComponent<Box1>().enabled = true;
                GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled = true;


                crosshair.SetActive(true);

                interactionUI.SetActive(true);

            }
        }

    }
}
