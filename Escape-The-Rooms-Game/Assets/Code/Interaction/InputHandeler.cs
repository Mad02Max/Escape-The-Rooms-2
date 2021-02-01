using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VHS
{
    public class InputHandeler : MonoBehaviour
    {

        #region Data
        // gets the data for the input
        [Space, Header("Input Data")]
        [SerializeField] private InteractionInputData interactionInputData = null;

        #endregion
        // does so it restets the inputdata when start
        private void Start()
        {
            interactionInputData.Reset();
        }
       // Checks for input
        public void Update()
        {
            GetInteractionInputData();
        }

        #region Custom Methods
        // gets the interaction input
        void GetInteractionInputData()
        {
            interactionInputData.interactedClicked = Input.GetKeyDown(KeyCode.E);

            interactionInputData.interactedRealease = Input.GetKeyUp(KeyCode.E);
            
        }
        #endregion 

    }
}