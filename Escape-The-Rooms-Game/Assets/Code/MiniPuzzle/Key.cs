using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace VHS
{
    public class Key : InteractableBase
    {
        //public GameObject keyObject;
        GameObject[] chests;
        public MiniPuzzleScript[] pickUpScript;

        public void Awake()
        {
            chests = GameObject.FindGameObjectsWithTag("MiniPuzzle");
            pickUpScript = new MiniPuzzleScript[chests.Length];
            for (int i = 0; i < chests.Length; i++)
            {
                pickUpScript[i] = chests[i].GetComponent<MiniPuzzleScript>();
            }
        }

        public override void OnInteract()
        {
            base.OnInteract();


            foreach (MiniPuzzleScript script in pickUpScript)
            {
                script.enabled = !script.enabled;
            }

            Destroy(gameObject);
        }
    }
}
