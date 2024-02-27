using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryZone : MonoBehaviour
{
    public GameObject victoryScreen;
    


    private void Start()
    {
        
        victoryScreen.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))

            {
          
            victoryScreen.SetActive(true);

            }

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

