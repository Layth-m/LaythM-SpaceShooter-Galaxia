using UnityEngine;

public class Health_Regain_spwan : MonoBehaviour
{

    public GameObject health_icon;

    public float minSpawnInterval = 2f;
    public float maxSpawnInterval = 8f;


    private float nextSpawnTime;

    void Start()
    {

        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {

        if (Time.time >= nextSpawnTime)
        {
            SpawnHealth_Icon();

            nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }

        if (transform.position.x < -8.15f || transform.position.y < -4.4f || transform.position.y > 4.25f)
        {

            Destroy(gameObject);
        }
    }

    void SpawnHealth_Icon()
    {

        Vector3 spawnPosition = new Vector3(
            Random.Range(-3f, 6f),
            Random.Range(-3.5f, 3.5f),
            0f
        );


        Instantiate(health_icon, spawnPosition, Quaternion.identity);
    }
   
}
