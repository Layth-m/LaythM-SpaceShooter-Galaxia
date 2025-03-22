


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

       
    }

    void SpawnAsteroid()
    {
      
        Vector3 spawnPosition = new Vector3(
            Random.Range( 1f , 6f),
            Random.Range( -3.5f, 3f),
            0f
        );

       
        Instantiate(asteroid, spawnPosition, Quaternion.identity);
    }
}