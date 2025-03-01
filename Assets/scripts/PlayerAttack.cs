
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackObjectPrefab;
    public Transform firePoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(attackObjectPrefab, firePoint.position, firePoint.rotation);
    }
}
