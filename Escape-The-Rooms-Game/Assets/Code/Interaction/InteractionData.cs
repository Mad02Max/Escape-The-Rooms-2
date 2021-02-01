using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    // Does so we can create Interaction Data
    [CreateAssetMenu(fileName = "Interaction Data", menuName = "InteractionSST/InteractionData")]
    public class InteractionData : ScriptableObject
    {
        // variables
        private InteractableBase p_Interactable;


        // Checks for interactable base
        public InteractableBase interactable
        {
            get => p_Interactable;
            set => p_Interactable = value;
        }


        // Makes one able to interact
        public void Interact()
        {
            p_Interactable.OnInteract();

            ResetData();
        }


        // Checks if it is the same interactable or diffrent 
        public bool IsSameInteractable(InteractableBase _newInteractable) => p_Interactable == _newInteractable;
        
        // resets the interactable data
        public void ResetData() => p_Interactable = null;

        public bool IsEmpty() => p_Interactable == null;
    }

}
