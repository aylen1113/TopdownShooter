using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
   
    public GameObject gameOverPanel;

    private void Start()
    {
        // Deactivate the game over panel initially
        gameOverPanel.SetActive(false);
    }

    public void ActiveScreen()
    {
        // Activate the game over panel
        gameOverPanel.SetActive(true);

       

    }


    public void PlayGame()
    {
        SceneManager.LoadScene("Game");

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }


}
