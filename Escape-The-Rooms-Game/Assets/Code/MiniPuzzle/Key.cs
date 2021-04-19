using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//By Caleb

namespace VHS
{
    public class Key : InteractableBase
    {
        //Creates an aray for all the chests.
        //Creates an aray for the objects having the script "MiniPuzzleScript".
        GameObject[] chests;
        public MiniPuzzleScript[] pickUpScript;

        //Automatically fills the arays with objects and making everything work.
        public void Awake()
        {
            chests = GameObject.FindGameObjectsWithTag("MiniPuzzle");
            pickUpScript = new MiniPuzzleScript[chests.Length];
            for (int i = 0; i < chests.Length; i++)
            {
                pickUpScript[i] = chests[i].GetComponent<MiniPuzzleScript>();
            }
        }

        //Makes it so that when the "key" is interacted with; the object is destroyed and the chests can be interacted with.
        public override void OnInteract()
        {
            base.OnInteract();

            

            foreach (MiniPuzzleScript script in pickUpScript)
            {
                GameObject.FindGameObjectWithTag("MiniPuzzle").GetComponent<MiniPuzzleScript>().interact = true;
                script.enabled = !script.enabled;
            }

            Destroy(gameObject);
        }
    }
}
