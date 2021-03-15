using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Made by Max and Caleb

namespace VHS
{
    public class OpenPuzzel : InteractableBase
    {

        public Toggle openPuzzle;

        public Toggle closePuzzle;

        public bool close = false;

        //Creates cameras
        
        public Camera characterCam;
        public GameObject puzzleCam;

        private bool puzzleCamActiveSelf;

        public GameObject interactionUI;

        private bool active = true;

        public GameObject crosshair;

        //Creates the arayes for the three differently tagged puzzle pieces.
        GameObject[] fourPiece;
        GameObject[] twoPiece;
        GameObject[] onePiece;
        public Box1[] boxScript;
        public Box1[] boxScript2;
        public Box1[] boxScript3;



        //Sets the cameras to what they should start as.
        void Awake()
        {

            
            // sets the cam to inactiv;
            puzzleCamActiveSelf = false;

            //interactionUI.SetActive(true);

            



        }

        //Uses the interaction script so that everything happenes when you are looking at the puzzle and pressing "E".
        //Switches the cameras and turn on and off different scripts so that they are active when they should.
        public override void OnInteract()
        {

            base.OnInteract();

            //characterCam.SetActive(!charCamActiveSelf);


            // Activerar Puzzle Cameran och stänger av den
            puzzleCam.SetActive(!puzzleCamActiveSelf);

            openPuzzle.isOn = true;

            if(close == true)
            {

                closePuzzle.isOn = true;

            }

            close = true;


            /*interactionUI.SetActive(!active);
            crosshair.SetActive(!active);*/


            //characterCam.enabled = false;

            //puzzleCam.enabled = true;

            //GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition(0.6, 40, -43);


            //Makes the main camera the opposite of what it was, on will turn off, off will turn on. -Caleb
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;

            //  GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;


            //Gör så att man bara kan röra karaktären, kameran, pussel cursor, pussel bitar, och "croucha" när man ska kunna. -Caleb
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = !GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = !GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled;
            GameObject.FindGameObjectWithTag("Crosshair").GetComponent<Image>().enabled = !GameObject.FindGameObjectWithTag("Crosshair").GetComponent<Image>().enabled;
            GameObject.FindGameObjectWithTag("UI").GetComponent<TextMeshProUGUI>().enabled = !GameObject.FindGameObjectWithTag("UI").GetComponent<TextMeshProUGUI>().enabled;

            //Makes the scripts for movement on the pieces turn off and on, same way as main-camera above. -Caleb
            foreach (Box1 script in boxScript)
            {
                script.enabled = !script.enabled;
            }
            foreach (Box1 script in boxScript2)
            {
                script.enabled = !script.enabled;
            }
            foreach (Box1 script in boxScript3)
            {
                script.enabled = !script.enabled;
            }

            //crosshair.SetActive(false);

            //interactionUI.SetActive(false);
        }

        //Constantly updates the arayes for the puzzle pieces
        private void Update()
        {
            fourPiece = GameObject.FindGameObjectsWithTag("4");
            twoPiece = GameObject.FindGameObjectsWithTag("2");
            onePiece = GameObject.FindGameObjectsWithTag("1");
            boxScript = new Box1[fourPiece.Length];
            boxScript2 = new Box1[twoPiece.Length];
            boxScript3 = new Box1[onePiece.Length];

            for (int i = 0; i < fourPiece.Length; i++)
            {
                boxScript[i] = fourPiece[i].GetComponent<Box1>();
            }
            for (int i = 0; i < twoPiece.Length; i++)
            {
                boxScript2[i] = twoPiece[i].GetComponent<Box1>();
            }
            for (int i = 0; i < onePiece.Length; i++)
            {
                boxScript3[i] = onePiece[i].GetComponent<Box1>();
            }
        }


    }
}
