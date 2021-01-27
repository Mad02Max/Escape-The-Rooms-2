using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class MinipuzzlePickUp : InteractableBase
    {

        public bool key = false;

        public override void OnInteract()
        {
            base.OnInteract();

            // Where the object can spawn
            //Instantiate(piece, pos.transform.position, Quaternion.identity);


            // Destroys object
            Destroy(gameObject);

        }

    }
}
