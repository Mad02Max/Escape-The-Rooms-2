using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlashlightTutorial : MonoBehaviour
{
    public Toggle flashlight;

    public GameObject tutorialInPuzzle;



    // Update is called once per frame
    void Update()
    {

        if (flashlight.isOn == true)
        {
            tutorialInPuzzle.SetActive(true);

            Destroy(gameObject);
        }

    }
}
