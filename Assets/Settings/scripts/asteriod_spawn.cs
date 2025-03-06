


using UnityEngine;

public class Asteroid_Spawn : MonoBehaviour
{
    public GameObject asteroid; 
    public GameObject player;
    public float minSpawnInterval = 1f; 
    public float maxSpawnInterval = 3f; 
 

    private float nextSpawnTime;

    void Start()
    {
        
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
       
        if (Time.time >= nextSpawnTime)
        {
            SpawnAsteroid();
          
            nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }

        if (transform.position.x < -8.15f || transform.position.y < -4.4f || transform.position.y > 4.25f)
        {

            Destroy(gameObject);
        }
    }

    void SpawnAsteroid()
    {
      
        Vector3 spawnPosition = new Vector3(
            Random.Range( 4 , 8.23f),
            Random.Range( -4.2f, 4.25f),
            0f
        );

       
        Instantiate(asteroid, spawnPosition, Quaternion.identity);
    }
}