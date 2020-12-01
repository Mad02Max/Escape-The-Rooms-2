using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//All done by Caleb

public class CollisionForCubes : MonoBehaviour
{ 
    
    //This is here to count the puzzle pieces that are on the board, it does this since when all the pieces are there, you can advance.
    int counter = 0;
    //int max = 34;


    //Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    //This checks if you have all the pieces on the board, and if you do; changes to a "win" screen.
    void Update()
    {
        if (counter == 144)
        {
            StartCoroutine(Waiter());
        }
    }

    //This checks so that when the puzzle pieces colides with the puzzle, the counter gets added to.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "4")
        {
            counter = counter + 4;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "1")
        {
            counter++;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "3")
        {
            counter = counter + 3;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "5")
        {
            counter = counter + 5;
            Debug.Log(counter);
        }


    }
    void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "4")
        {
            counter = counter - 4;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "1")
        {            
            counter--;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "3")
        {
            counter = counter - 3;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "5")
        {
            counter = counter - 5;
            Debug.Log(counter);
        }

    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(sceneName: "Victory");

    }




}
