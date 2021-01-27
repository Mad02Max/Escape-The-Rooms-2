using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{

    // gets all of the information needed for the interactable objects
    public interface IInteractable
    {
        float HoldDuration { get; }

        bool HoldInteract { get; }

        bool MultipleUse { get; }

        bool IsInteractable { get; }

        string textMessage { get; }

        void OnInteract();
    }
}