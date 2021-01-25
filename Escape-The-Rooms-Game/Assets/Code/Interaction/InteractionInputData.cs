using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{

    // Checks if key is pressed or held and if released

    [CreateAssetMenu(fileName = "Interaction", menuName = "InteractionSST/InputData")]
    public class InteractionInputData : ScriptableObject
    {

        private bool p_interactedClicked;

        private bool p_interactedRelease;

        public bool interactedClicked
        {
            get => p_interactedClicked;

            set => p_interactedClicked = value;

        }

        public bool interactedRealease
        {
            get => p_interactedRelease;

            set => p_interactedRelease = value;
        }


        public void Reset()
        {
            p_interactedClicked = false;

            p_interactedRelease = false;
        }

    }
}


