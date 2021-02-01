using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class DestroyInteractable : InteractableBase
    {
        public override void OnInteract()
        {
            // calls on OnInteract
            base.OnInteract();

            // Destroys the object
            Destroy(gameObject);

        }

    }
}
