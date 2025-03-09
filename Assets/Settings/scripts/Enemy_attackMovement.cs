
using UnityEngine;

public class Enemy_attackMovement : MonoBehaviour
{
    private float speed = 10f;
    private float lifetime = 1.5f;
    public GameObject VFX_Flame;


    public GameObject VFX_HitEnemy;
    public GameObject VFX_HitPlayer;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Instantiate(VFX_Flame, transform.position, Quaternion.identity);

            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Enemy")
        {

           
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "Player")
        {

            Instantiate(VFX_HitPlayer, transform.position, Quaternion.identity);

            var healthComponent = collision.gameObject.GetComponent<playerHealth>();
            healthComponent.TakeDamage(50f);
            Destroy(gameObject);
        }
    }
}