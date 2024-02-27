using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;
    public Animator animator;



    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        float combinedSpeed = Mathf.Abs(movement.x) + Mathf.Abs(movement.y);


        animator.SetFloat("Speed", combinedSpeed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMainMenu();
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            CollectCoin(collision.gameObject);
        }
    }

    private void CollectCoin(GameObject coin)
    {
       

        Destroy(coin);
    }

    private void ShowMainMenu()
    {
      
        SceneManager.LoadScene("MainMenu");
    }

}


