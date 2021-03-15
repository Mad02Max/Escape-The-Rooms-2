using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VHS
{
    public class PickUp : InteractableBase
    {

        public Toggle pressE;

        public GameObject piece;

        public GameObject pos;
       
        // When Interacting with object destroy it + spawn on position
        public override void OnInteract()
        {
            base.OnInteract();

            // Where the object can spawn
            Instantiate(piece, pos.transform.position, Quaternion.identity);

            pressE.isOn = true;

            // Destroys object
            Destroy(gameObject);

        }

    }
}
