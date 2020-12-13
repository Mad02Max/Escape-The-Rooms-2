using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveText : MonoBehaviour
{
    public Text tutorial1;
    public Text tutorial2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            tutorial1.enabled = false;
            tutorial2.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            tutorial1.enabled = true;
            tutorial2.enabled = true;
        }
    }
}
