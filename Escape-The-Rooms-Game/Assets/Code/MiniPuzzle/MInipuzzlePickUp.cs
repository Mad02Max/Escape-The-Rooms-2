using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class MinipuzzlePickUp : InteractableBase
    {

        public bool key = false;

        public GameObject piece1;

        public GameObject pos1;

        private void Update()
        {
            
        }

        public override void OnInteract()
        {
            if(key == true)
            {
                base.OnInteract();

                // Where the object can spawn
                Instantiate(piece1, pos1.transform.position, Quaternion.identity);


                // Destroys object
                Destroy(gameObject);

            }
        }

    }
}
