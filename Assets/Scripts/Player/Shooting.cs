using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public Animator animator;
    private Camera mainCam;
    private Vector3 mousePos;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            animator.SetBool("IsShooting", true);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("IsShooting", false);
        }
    


}
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Quaternion rotation = Quaternion.Euler(0, 0, 90);
        bullet.transform.rotation = rotation;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}