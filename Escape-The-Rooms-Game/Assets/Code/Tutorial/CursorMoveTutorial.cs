using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CursorMoveTutorial : MonoBehaviour
{
    public Toggle wasdMove;

    public GameObject tutorialInPuzzle;



    // Update is called once per frame
    void Update()
    {

        if (wasdMove.isOn == true)
        {
            tutorialInPuzzle.SetActive(true);

            Destroy(gameObject);
        }

    }
}
