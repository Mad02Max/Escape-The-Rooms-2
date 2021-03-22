using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorialInpuzzle : MonoBehaviour
{
    public Toggle PickUpPiece;

    public Toggle PutDownPiece;

    public GameObject tutorial;

    private void Awake()
    {
        PickUpPiece.isOn = false;

        PutDownPiece.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (PickUpPiece.isOn == true && PutDownPiece.isOn == true)
        {
            tutorial.SetActive(true);
            
            Destroy(gameObject);
        }

    }

}
