using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePieces : MonoBehaviour
{
    private Rigidbody rigidPieces;
    public bool movePiece;



    // Start is called before the first frame update
    void Start()
    {
        rigidPieces = GetComponent<Rigidbody>();
    }

    public void Awake()
    {
        movePiece = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movePiece == true)
        {





        }



    }
}
