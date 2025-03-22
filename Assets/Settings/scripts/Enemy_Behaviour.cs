using UnityEngine;
public class Enemy_Behaviour : MonoBehaviour
{
    public float speed = 5f;
    public float shootingInterval = 0.3f;
    public GameObject bulletPrefab;
  
    public Transform bulletSpawnPoint;

    private float shootingTimer;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
       
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        // Shooting logic
        shootingTimer += Time.deltaTime;
        if (shootingTimer >= shootingInterval)
        {
            Shoot();
            shootingTimer = 0f;
        }
        if (transform.position.x < -8.15f || transform.position.y < -4.4f || transform.position.y > 4.25f)
        {

            Destroy(gameObject);
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var healthComponent = collision.gameObject.GetComponent<playerHealth>();
            Debug.LogError("collision detacted");

            healthComponent.TakeDamage(100f);

        }
    }
}