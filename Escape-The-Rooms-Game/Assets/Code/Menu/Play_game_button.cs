using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_game_button : MonoBehaviour
{
    public void ClickButton()
    {
        SceneManager.LoadScene(sceneName: "Game 1");
    }
}
