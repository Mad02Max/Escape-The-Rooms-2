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

            [SerializeField] private float holdDuration;

        
            [Space]


            [SerializeField] private bool holdInteract;

            [SerializeField] private bool multipleUse;

            [SerializeField] private bool isInteractable;

            [SerializeField] private string text = "Interact" ;

        #endregion

        #region Properties
            public float HoldDuration => holdDuration;


            public bool HoldInteract => holdInteract;

            public bool MultipleUse => multipleUse;

            public bool IsInteractable => isInteractable;

        public string textMessage => text;

        #endregion

        #region Methods
        public virtual void OnInteract()
        {
            Debug.Log("INTERACTED: " + gameObject.name);
        }

        #endregion
    }
}

