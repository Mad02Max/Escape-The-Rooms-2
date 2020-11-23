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

        [Space, Header("Ray Settings")]
        [SerializeField] private float rayDistance = 0f;
        [SerializeField] private float raySphereRadius = 0f;
        [SerializeField] private LayerMask interactableLayer = ~0;

        private Camera m_cam;

        private bool p_interacting;
        private float p_holdTimer = 0f;

        #endregion


        #region Built In Methods      
        void Awake()
        {
            m_cam = FindObjectOfType<Camera>();
        }

        void Update()
        {
            CheckForInteractable();
            CheckForInteractableInput();
        }
        #endregion


        #region Custom methods         
        void CheckForInteractable()
        {
            Ray _ray = new Ray(m_cam.transform.position, m_cam.transform.forward);
            RaycastHit _hitInfo;

            bool _hitSomething = Physics.SphereCast(_ray, raySphereRadius, out _hitInfo, rayDistance, interactableLayer);

            if (_hitSomething)
            {
                InteractableBase _interactable = _hitInfo.transform.GetComponent<InteractableBase>();

                if (_interactable != null)
                {
                    if (interactionData.IsEmpty())
                    {
                        interactionData.interactable = _interactable;

                        uIPanel.SetText(_interactable.textMessage);                    
                   
                    }
                    else
                    {
                        if (!interactionData.IsSameInteractable(_interactable))
                        {
                            interactionData.interactable = _interactable;

                            uIPanel.SetText(_interactable.textMessage);

                        }

                    }
                }
                
            }
            else
            {
                uIPanel.ResetUI();
                interactionData.ResetData();
            }

            Debug.DrawRay(_ray.origin, _ray.direction * rayDistance, _hitSomething ? Color.green : Color.red);
        }

        void CheckForInteractableInput()
        {
            if (interactionData.IsEmpty())
                return;

            if (interactionInputData.interactedClicked)
            {
                p_interacting = true;

                p_holdTimer = 0f;
            }

            if (interactionInputData.interactedRealease)
            {
                p_interacting = false;

                p_holdTimer = 0f;

                uIPanel.UpdateProgressBar(p_holdTimer);
            }

            if (p_interacting)
            {
                if (!interactionData.interactable.IsInteractable)
                    return;

                if (interactionData.interactable.HoldInteract)
                {
                    p_holdTimer += Time.deltaTime;

                    float heldPercent = p_holdTimer / interactionData.interactable.HoldDuration;
                    
                    uIPanel.UpdateProgressBar(heldPercent);

                    if (heldPercent > 1f)
                    {
                        interactionData.Interact();

                        p_interacting = false;
                    }
                }
                else
                {
                    interactionData.Interact();

                    p_interacting = false;
                }
            }
        }
        #endregion
    }
}
