﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RotateTutorial : MonoBehaviour
{

    public Toggle pressB;

    public Toggle pressV;

    public GameObject tutorialBackgorund;



    // Update is called once per frame
    void Update()
    {

        if (pressB.isOn == true && pressV.isOn == true)
        {
            tutorialBackgorund.transform.position = transform.position + new Vector3(-325, 0, 0);

            Destroy(gameObject);
        }

    }
}