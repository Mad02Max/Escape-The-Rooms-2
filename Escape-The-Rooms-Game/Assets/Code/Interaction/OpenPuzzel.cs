﻿using System.Collections;
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
<<<<<<< HEAD
=======


        /*[SerializeField] Camera characterCam;
        [SerializeField] Camera puzzleCam;

        [SerializeField] KeyCode[] toggleCamera;*/

        //public Movement movement;
>>>>>>> parent of 6c2fd7b... crouch cam script

        //Sets the cameras to what they should start as.
        void Awake()
        {
            characterCam.enabled = true;
            puzzleCam.enabled = false;
<<<<<<< HEAD

=======
>>>>>>> parent of 6c2fd7b... crouch cam script
        }

        //Uses the interaction script so that everything happenes when you are looking at the puzzle and pressing "E".
        //Switches the cameras and turn on and off different scripts so that they are active when they should.
        public override void OnInteract()
        {


            base.OnInteract();

<<<<<<< HEAD
<<<<<<< HEAD


            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
<<<<<<< HEAD
            GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;            
=======
            GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;


            //characterCam.enabled = false;

            //puzzleCam.enabled = true;
>>>>>>> parent of 6c2fd7b... crouch cam script
=======
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
            GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;            
>>>>>>> parent of 5fde4d5... open puzzle stuff + game build
=======
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
            GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;            
>>>>>>> parent of 5fde4d5... open puzzle stuff + game build

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        }        
=======
        }
>>>>>>> parent of 6c2fd7b... crouch cam script
=======
        }        
>>>>>>> parent of 5fde4d5... open puzzle stuff + game build
=======
        }        
>>>>>>> parent of 5fde4d5... open puzzle stuff + game build
    }
}
