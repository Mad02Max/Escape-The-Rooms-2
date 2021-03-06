﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VHS
{
    public class MiniPuzzleScript : InteractableBase
    {

        public Toggle holdE;

        public bool interact;
        
        // when it starts the script is disabled
        public void Awake()
        {
            interact = false;
        }
        public void Start()
        {
            
        }

        public void Update()
        {
            if (interact == false)
            {
                GameObject.FindGameObjectWithTag("interactibleBase").GetComponent<InteractableBase>().enabled = false;
            }
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

            holdE.isOn = true;
            GameObject.FindGameObjectWithTag("Door").GetComponent<Open>().open = true;
            GameObject.FindGameObjectWithTag("Lock").GetComponent<Open>().open = true;

            // Destroys object
            Destroy(gameObject);

        }
        

    }

    

}
