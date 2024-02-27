using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Transform player;
    public PlayerHealth playerHealth;
    public int damageAmount = 10;
    public float detectionRange = 5f;
    public GameObject coinPrefab;



    // Start is called before the first frame update
    void Start()
    {
       
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
   

  

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
           

            Destroy(collision.gameObject);
            Disappear();

        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit");

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }

    private void Disappear()
    {
        Destroy(gameObject);
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
    }
}