
using UnityEngine;

public class Attack_movement : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }
}
