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
        //Creates cameras
        
        public Camera characterCam;
        public GameObject puzzleCam;

        private bool puzzleCamActiveSelf;

        public GameObject interactionUI;

        private bool active = true;

        public GameObject crosshair;

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


            /*interactionUI.SetActive(!active);
            crosshair.SetActive(!active);*/


            //characterCam.enabled = false;

            //puzzleCam.enabled = true;

            //GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition(0.6, 40, -43);



            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;

            //  GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;


            //Gör så att man bara kan röra karaktären, kameran, pussel cursor, pussel bitar, och "croucha" när man ska kunna
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = !GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = !GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled;
            GameObject.FindGameObjectWithTag("Crosshair").GetComponent<Image>().enabled = !GameObject.FindGameObjectWithTag("Crosshair").GetComponent<Image>().enabled;
            //GameObject.FindGameObjectWithTag("UI").GetComponent<textMeshPro>().enabled = !GameObject.FindGameObjectWithTag("UI").GetComponent<textMeshPro>().enabled;
            //GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled = false;

            //GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled;


            foreach (Box1 script in boxScript)
            {
                script.enabled = !script.enabled;
                //Debug.Log("ScriptPå");
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
