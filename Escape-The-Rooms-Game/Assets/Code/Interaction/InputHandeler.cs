using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VHS
{
    public class InputHandeler : MonoBehaviour
    {

        #region Data

        [Space, Header("Input Data")]
        [SerializeField] private InteractionInputData interactionInputData = null;

        #endregion

        private void Start()
        {
            interactionInputData.Reset();
        }
        public void Update()
        {
            GetInteractionInputData();
        }

        #region Custom Methods
        void GetInteractionInputData()
        {
            interactionInputData.interactedClicked = Input.GetKeyDown(KeyCode.E);

            interactionInputData.interactedRealease = Input.GetKeyUp(KeyCode.E);
            
        }
        #endregion 

    }
}