using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartNewGame()
    {
        // You can add any code here to start a new game
        Debug.Log("Starting a new game!");
        // For example, you might load a new scene
        SceneManager.LoadScene("Loading");
    }

    // This function is called when the "Exit" button is clicked
    public void ExitGame()
    {
        // You can add any code here to handle game exit
        Debug.Log("Exiting the game!");
        // For example, you might quit the application
        Application.Quit();
    }
}
