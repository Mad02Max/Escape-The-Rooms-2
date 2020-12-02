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

    //This checks if you have all the pieces on the board, and if you do; changes to a "win" screen.
    //If you have all the pieces, a method will start, that method makes it so that the game waits for x seconds.
    //This is here because otherwise you would just need to tuch the board with the piece to have it count.
    void Update()
    {
        if (counter == 144)
        {
            StartCoroutine(Waiter());
        }
    }

    //This checks so that when the puzzle pieces colides with the puzzle, the counter gets added to.
    //Also, takes away from the counter if any piece leaves the board.
    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "1")
        {
            counter++;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "2")
        {
            counter = counter + 2;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "4")
        {
            counter = counter + 4;
            Debug.Log(counter);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "1")
        {
            counter--;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "2")
        {
            counter = counter - 2;
            Debug.Log(counter);
        }
        if (collision.gameObject.tag == "4")
        {
            counter = counter - 4;
            Debug.Log(counter);
        }
    }

    //This is the method that waits for x seconds. Curently: 15 sec.
    //After this time, you win.
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(sceneName: "Victory");
    }
}
