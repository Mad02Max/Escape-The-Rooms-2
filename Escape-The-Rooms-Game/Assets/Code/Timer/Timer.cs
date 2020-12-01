using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(300);
        Destroy(gameObject);

    }

}
