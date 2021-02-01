using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace VHS
{
    public class InteractionUI : MonoBehaviour
    {

        [SerializeField] private Image progressBar;

        [SerializeField] private TextMeshProUGUI textMeshProUGUI;

        // Sets the text for an object
        public void SetText(string text)
        {

            textMeshProUGUI.SetText(text);

        }

        // Updates the progressbar
        public void UpdateProgressBar(float fillAmount)
        {
            progressBar.fillAmount = fillAmount;
        }

        // Resets the progressbar
        public void ResetUI()
        {

            progressBar.fillAmount = 0;
            textMeshProUGUI.SetText("");

        }

    }
}

