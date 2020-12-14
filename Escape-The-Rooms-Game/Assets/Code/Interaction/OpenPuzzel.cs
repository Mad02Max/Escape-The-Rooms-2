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

        //Sets the cameras to what they should start as.
        void Awake()
        {
            characterCam.enabled = true;
            puzzleCam.enabled = false;

        }

        //Uses the interaction script so that everything happenes when you are looking at the puzzle and pressing "E".
        //Switches the cameras and turn on and off different scripts so that they are active when they should.
        public override void OnInteract()
        {
            base.OnInteract();

            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
            GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;            

            //Gjord av Caleb
            //Gör så att man bara kan röra karaktären, kameran, pussel cursor, pussel bitar, och "croucha" när man ska kunna
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = !GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = !GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled;
            GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled = !GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled;
            GameObject.FindGameObjectWithTag("1").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("1").GetComponent<Box1>().enabled;
            GameObject.FindGameObjectWithTag("2").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("2").GetComponent<Box1>().enabled;
            GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled;
            //Slutet av gjort av Caleb
        }        
    }
}
