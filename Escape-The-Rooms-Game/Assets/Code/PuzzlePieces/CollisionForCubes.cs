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
        //max--;

        /*if (counter == 34)
        {
            SceneManager.LoadScene(sceneName: "Victory");
        }*/

        /*if (counter > 34)
        {
            counter = 34;
        }*/
        
    }

    //This checks so that when the puzzle pieces colides with the puzzle, the counter gets added to.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TetrisPiece" == true)
        {
            counter++;
            Debug.Log(counter);
            //max++;
            //Debug.Log(max);
        }
        if (collision.gameObject.tag == "Box1" == true)
        {
            counter = counter + 4;
            Debug.Log(counter);
        }


    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "TetrisPiece")
        {
            counter--;
            Debug.Log(counter);
        }
        
        if (collision.gameObject.tag == "Box1")
        {
            counter = counter - 4;
            Debug.Log(counter);
        }


    }



}
