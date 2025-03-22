
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackObjectPrefab;
    public Transform firePoint;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Shoot();

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Instantiate(attackObjectPrefab, firePoint.position, firePoint.rotation);
    }
}
