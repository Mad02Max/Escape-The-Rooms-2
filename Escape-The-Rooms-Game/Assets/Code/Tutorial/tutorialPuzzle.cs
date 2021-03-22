using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorialPuzzle : MonoBehaviour
{
    public Toggle PickUpPiece;

    public Toggle PutDownPiece;

    public GameObject tutorial;



    // Update is called once per frame
    void Update()
    {

        if (PickUpPiece.isOn == true && PutDownPiece.isOn == true)
        {
            gameObject.SetActive(true);
        }

    }

}
