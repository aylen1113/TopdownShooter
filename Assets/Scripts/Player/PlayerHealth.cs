using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public HealthBar healthBar;

    public GameOverScreen gameOverScreen;



    private void Start()
    {

        currentHealth = maxHealth;
        

    }


    public void TakeDamage(int damageAmount)
    {
        Debug.Log("Damage!");
        currentHealth -= damageAmount;
       healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {

            gameOverScreen.ActiveScreen();

        }
    }
}