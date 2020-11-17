using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VHS;

namespace VHS
{
    public class InteractableBase : MonoBehaviour, IInteractable
    {

        [Header("Interactable Settings")]

        #region Variables

            public float holdDuration;

        
            [Space]


            public bool holdInteract;

            public bool multipleUse;

            public bool isInteractable;

        #endregion

        #region Properties
            public float HoldDuration => holdDuration;


            public bool HoldInteract => holdInteract;

            public bool MultipleUse => multipleUse;

            public bool IsInteractable => isInteractable;

        #endregion

        #region Methods
        public virtual void OnInteract()
        {
            Debug.Log("INTERACTED: " + gameObject.name);
        }

        #endregion
    }
}

