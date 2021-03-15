using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorialPickUp : MonoBehaviour
{

    public Toggle pressE;

    public Toggle holdE;

    public GameObject puzzleTutorial;



    // Update is called once per frame
    void Update()
    {

        if (pressE.isOn == true && holdE.isOn == true)
        {
            puzzleTutorial.SetActive(true);

            Destroy(gameObject);
        }

    }

}
