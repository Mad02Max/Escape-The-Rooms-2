﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Made by Caleb

public class Play_game_button : MonoBehaviour
{
    //Changes the scene when the button is pressed.
    public void ClickButton()
    {
        SceneManager.LoadScene(sceneName: "Game 1");
        Cursor.lockState = CursorLockMode.Locked;
    }
}
