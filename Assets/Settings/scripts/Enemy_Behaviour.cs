

using UnityEngine;

public class Enemy_Behaviour : MonoBehaviour
{
    public float speed = 5f;
    public float shootingInterval = 0.3f;
    public GameObject bulletPrefab;
    public Transform player;
    public Transform bulletSpawnPoint;

    private float shootingTimer;

    void Update()
    {
        // Move towards the player
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            Quaternion lookRotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed * 2);
        }

        // Shooting logic
        shootingTimer += Time.deltaTime;
        if (shootingTimer >= shootingInterval)
        {
            Shoot();
            shootingTimer = 0f;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}


