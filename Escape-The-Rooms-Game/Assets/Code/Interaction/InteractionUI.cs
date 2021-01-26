﻿using System.Collections;
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


        public void SetText(string text)
        {

            textMeshProUGUI.SetText(text);

        }

        public void UpdateProgressBar(float fillAmount)
        {
            progressBar.fillAmount = fillAmount;
        }

        public void ResetUI()
        {

            progressBar.fillAmount = 0;
            textMeshProUGUI.SetText("");

        }

    }
}

