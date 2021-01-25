using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class PickUp : InteractableBase
    {

        public GameObject piece;

        public GameObject pos;
       
        // When Interacting with object destroy it + spawn on position
        public override void OnInteract()
        {
            base.OnInteract();

            Instantiate(piece, pos.transform.position, Quaternion.identity);

            Destroy(gameObject);

        }

    }
}
