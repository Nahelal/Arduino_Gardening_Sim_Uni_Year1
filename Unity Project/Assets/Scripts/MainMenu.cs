using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayerQuitGame()
    {
        //closes game when button pressed
        Debug.Log("Quit Game");
        Application.Quit();
    }
    public void PlayerStartGame()
    {
        //starts main game scene when button pressed
        Debug.Log("Play Start Scene");
        SceneManager.LoadScene("Plant growth");
    }
}
