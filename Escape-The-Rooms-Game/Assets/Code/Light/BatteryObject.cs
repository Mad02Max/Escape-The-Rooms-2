using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class BatteryObject : InteractableBase
    {

        public GameObject battery;


        public override void OnInteract()
        {
            base.OnInteract();

            GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Battery>().batteryLife = 
            GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Battery>().batteryLife + 90;

            Destroy(gameObject);
        }
    }
}
