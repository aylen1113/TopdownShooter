using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletForce = 20f;
    public Rigidbody2D rb;
    private Camera mainCam;
    private Vector3 mousePos;
    public float bulletLifetime = 2f;  

    // Start is called before the first frame update
    void Start()
    {
        

        rb = GetComponent<Rigidbody2D>();

        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);


        Vector2 direction = (mousePos - transform.position).normalized;

        
        rb.velocity = direction * bulletForce;

      
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Destroy(gameObject, bulletLifetime);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

