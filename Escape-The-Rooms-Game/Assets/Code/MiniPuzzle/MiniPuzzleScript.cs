using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class MiniPuzzleScript : InteractableBase
    {
        // when it starts the script is disabled
        public void Awake()
        {
            GetComponent<MiniPuzzleScript>().enabled = false;
        }


        // variables and postitions
        public GameObject piece1;

        public GameObject pos1;

        public GameObject piece2;

        public GameObject pos2;

        public GameObject piece3;

        public GameObject pos3;

        public GameObject piece4;

        public GameObject pos4;

        public override void OnInteract()
        {

            base.OnInteract();

            // Where the object can spawn
            Instantiate(piece1, pos1.transform.position, Quaternion.identity);
            Instantiate(piece2, pos2.transform.position, Quaternion.identity);
            Instantiate(piece3, pos3.transform.position, Quaternion.identity);
            Instantiate(piece4, pos4.transform.position, Quaternion.identity);


            // Destroys object
            Destroy(gameObject);

        }


    }
}
