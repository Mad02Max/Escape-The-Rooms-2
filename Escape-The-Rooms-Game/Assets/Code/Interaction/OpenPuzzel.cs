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
        public GameObject puzzleCam;

        private bool charCamActiveSelf;

        private bool puzzleCamActiveSelf;

        public GameObject interactionUI;

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

            charCamActiveSelf = true;
            puzzleCamActiveSelf = false;

            //crosshair.SetActive(true);

            //interactionUI.SetActive(true);

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

        //Uses the interaction script so that everything happenes when you are looking at the puzzle and pressing "E".
        //Switches the cameras and turn on and off different scripts so that they are active when they should.
        public override void OnInteract()
        {

            base.OnInteract();



            //characterCam.SetActive(!charCamActiveSelf);

            puzzleCam.SetActive(!puzzleCamActiveSelf);

            //characterCam.enabled = false;

            //puzzleCam.enabled = true;

            //GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition(0.6, 40, -43);



            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;

            //GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<GameObject>().SetActive() = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<GameObject>().SetActive();


            //Gör så att man bara kan röra karaktären, kameran, pussel cursor, pussel bitar, och "croucha" när man ska kunna
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = !GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled;
            //GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = !GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled;
            //GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled = false;



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

        /*private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                characterCam.enabled = true;

                puzzleCam.enabled = false;

                GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = true;
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = true;
                GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = false;
                //GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Crouching>().enabled = true;

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


                //crosshair.SetActive(true);

                //interactionUI.SetActive(true);

            }
        }*/

    }
}
