using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorialPuzzle : MonoBehaviour
{
    public Toggle openPuzzle;

    public Toggle closePuzzle;

    public GameObject tutorial;



    // Update is called once per frame
    void Update()
    {

        if (openPuzzle.isOn == true && closePuzzle.isOn == true)
        {
            Destroy(tutorial);
        }

    }

}
