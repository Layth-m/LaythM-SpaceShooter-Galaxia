
using UnityEngine;

public class Attack_movement : MonoBehaviour
{
    public float speed = 20f;
    public float lifetime = 0.5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);

        }
    }
}