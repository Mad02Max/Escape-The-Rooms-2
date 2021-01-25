using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "InteractionInput", menuName = "InteractionSST")]

public class InteractionInput : ScriptableObject
{

    private bool p_interactedClicked;

    private bool p_interactedReleased;


    // Checks if it is clicked/held
    public bool interactedClicked
    {
        get => p_interactedClicked;

        set => p_interactedClicked = value;
    }

    // Checks if it key released
    public bool interactedReleased
    {
        get => p_interactedReleased;

        set => p_interactedReleased = value;
    }

    // Resets Clicked and relesed
    public void Reset()
    {
        p_interactedClicked = false;

        p_interactedReleased = false;
    }
}
