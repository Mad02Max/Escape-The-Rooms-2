using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class OpenPuzzel : InteractableBase
    {
        public Camera characterCam;
        public Camera puzzleCam;
        public Camera crouchCam;

        // Start is called before the first frame update
        void Awake()
        {
            characterCam.enabled = true;
            puzzleCam.enabled = false;
            crouchCam.enabled = false;
        }
        public override void OnInteract()
        {
            base.OnInteract();

            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled;
            GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("PuzzleCamera").GetComponent<Camera>().enabled;
            

            //Gjord av Caleb
            //Gör så att man bara kan röra karaktären, kameran och pussel cursor när man ska kunna
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = !GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LookAround>().enabled;
            GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled = !GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMove>().enabled;
            GameObject.FindGameObjectWithTag("1").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("1").GetComponent<Box1>().enabled;
            GameObject.FindGameObjectWithTag("2").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("2").GetComponent<Box1>().enabled;
            GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled = !GameObject.FindGameObjectWithTag("4").GetComponent<Box1>().enabled;
            //Slutet av gjort av Caleb
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Camera>().enabled = !GameObject.FindGameObjectWithTag("crouchCam").GetComponent<Camera>().enabled;
            }
        }
    }
}
