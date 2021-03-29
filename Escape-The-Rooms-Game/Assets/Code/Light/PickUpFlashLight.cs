﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By Caleb

namespace VHS
{
    public class PickUpFlashLight : InteractableBase
    {
        public GameObject flashlight;

        //Creates a visual studio object to interact with the unity batteries.

        //Makes it so that the battery is added to on interaction.
        //Deletes the battery after interaction.
        public override void OnInteract()
        {
            base.OnInteract();

            flashlight.active = true;

            Destroy(gameObject);
        }
    }
}


