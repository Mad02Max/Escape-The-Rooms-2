using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveScript : MonoBehaviour
{
    public Text objectiveText;

    public void Start()
    {
        StartCoroutine(Waiter());
    }


    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }



}
