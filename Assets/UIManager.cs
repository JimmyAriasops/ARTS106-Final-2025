using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Project 1 - GrayBoxing - Jimmy Arias");
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}


