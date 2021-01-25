using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class InteractionController : MonoBehaviour
    {
        #region Variables    
        [Space, Header("Data")]
        [SerializeField] private InteractionInputData interactionInputData = null;
        [SerializeField] private InteractionData interactionData = null;


        [Space, Header("UI")]
        [SerializeField] private InteractionUI uIPanel;

        // Ray Casting Settings
        [Space, Header("Ray Settings")]
        [SerializeField] private float rayDistance = 0f;
        [SerializeField] private float raySphereRadius = 0f;
        [SerializeField] private LayerMask interactableLayer = ~0;

        private Camera p_cam;

        private bool p_interacting;
        private float p_holdTimer = 0f;

        #endregion


        #region Built In Methods      
        void Awake()
        {
            // So whe have the Camera
            p_cam = FindObjectOfType<Camera>();
        }

        void Update()
        {
            // Updateing to metods
            CheckForInteractable();
            CheckForInteractableInput();
        }
        #endregion


        #region Custom methods         
        void CheckForInteractable()
        {
            // Creats the Ray casting and checks if his something
            Ray _ray = new Ray(p_cam.transform.position, p_cam.transform.forward);
            RaycastHit _hitInfo;

            bool _hitSomething = Physics.SphereCast(_ray, raySphereRadius, out _hitInfo, rayDistance, interactableLayer);

            if (_hitSomething)
            {
                // Gets the interactable base if hit something
                InteractableBase _interactable = _hitInfo.transform.GetComponent<InteractableBase>();

                if (_interactable != null)
                {
                    if (interactionData.IsEmpty())
                    {
                        // Shows text of interactable and gets the data 
                        interactionData.interactable = _interactable;

                        uIPanel.SetText(_interactable.textMessage);                    
                   
                    }
                    else
                    {
                        if (!interactionData.IsSameInteractable(_interactable))
                        {
                            // Shows text of interactable and gets the data 
                            interactionData.interactable = _interactable;

                            uIPanel.SetText(_interactable.textMessage);

                        }

                    }
                }
                
            }
            else
            {
                // Removes text and resets data if it doesn't hit something
                uIPanel.ResetUI();
                interactionData.ResetData();
            }

            // Shows the ray if it hits something and if it doesn't
            Debug.DrawRay(_ray.origin, _ray.direction * rayDistance, _hitSomething ? Color.green : Color.red);
        }

        // Checks for input
        void CheckForInteractableInput()
        {
            if (interactionData.IsEmpty())
                return;

            // Checks if clicked 
            if (interactionInputData.interactedClicked)
            {
                p_interacting = true;

                p_holdTimer = 0f;
            }

            // Checks if released
            if (interactionInputData.interactedRealease)
            {
                p_interacting = false;

                p_holdTimer = 0f;

                uIPanel.UpdateProgressBar(p_holdTimer);
            }

            // Interacting with objects
            if (p_interacting)
            {
                // if it isn't interactable it stops
                if (!interactionData.interactable.IsInteractable)
                    return;

                // Cheacks if it is hold interact 
                if (interactionData.interactable.HoldInteract)
                {
                    // Updates hold timer with Time.deltaTime
                    p_holdTimer += Time.deltaTime;

                    // Sees how many precent that the player has held
                    float heldPercent = p_holdTimer / interactionData.interactable.HoldDuration;
                    
                    // Updates Progress bar so the player sees how long it has left
                    uIPanel.UpdateProgressBar(heldPercent);

                    // Pick up once held precent is 1 or greater
                    if (heldPercent > 1f)
                    {
                        interactionData.Interact();

                        p_interacting = false;
                    }
                }
                else
                {
                    // Just pick up
                    interactionData.Interact();

                    p_interacting = false;
                }
            }
        }
        #endregion
    }
}
