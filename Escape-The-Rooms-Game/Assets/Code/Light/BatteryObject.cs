using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//By Caleb

namespace VHS
{
    public class BatteryObject : InteractableBase
    {
        public Toggle pickUp;

        //Creates a visual studio object to interact with the unity batteries.
        public GameObject battery;

        //Makes it so that the battery is added to on interaction.
        //Deletes the battery after interaction.
        public override void OnInteract()
        {
            base.OnInteract();

            GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Battery>().batteryLife = 
            GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Battery>().batteryLife + 90;

            pickUp.isOn = true;

            Destroy(gameObject);
        }
    }
}
