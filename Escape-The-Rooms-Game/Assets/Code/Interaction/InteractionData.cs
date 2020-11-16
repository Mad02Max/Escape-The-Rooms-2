using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    [CreateAssetMenu(fileName = "Interaction Data", menuName = "InteractionSST/InteractionData")]
    public class InteractionData : ScriptableObject
    {

        private InteractableBase p_Interactable;

        public InteractableBase interactable
        {
            get => p_Interactable;
            set => p_Interactable = value;
        }

        public void Interact()
        {
            p_Interactable.OnInteract();

            ResetData();
        }

        public bool IsSameInteractable(InteractableBase _newInteractable) => p_Interactable == _newInteractable;
        

        public void ResetData() => p_Interactable = null;

        public bool IsEmpty() => p_Interactable == null;
    }

}
