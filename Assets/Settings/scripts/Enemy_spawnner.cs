using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject[] enemyVariants; 
    public GameObject enemy;
    public float minSpawnInterval = 7f; 
    public float maxSpawnInterval = 10f; 

    public float spawnAreaMinY = -4.06f; 
    public float spawnAreaMaxY = 4.37f; 

    public float spawnXPosition = 8.06f; 

    private float nextSpawnTime;

    public float spawnRadiusCheck = 1f;

    void Start()
    {
        
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
        
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemyBatch();
          
            nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    void SpawnEnemyBatch()
    {
       
        int batchSize = Random.Range(2, 5); 

        for (int i = 0; i < batchSize; i++)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    { 
        Vector3 spawnPosition = GetValidSpawnPosition();

        Quaternion spawnRotation = Quaternion.Euler(0f, 0f, 90f);
        //Instantiate(enemy, spawnPosition, spawnRotation);

        if (enemyVariants.Length > 0)
        {
            int randomIndex = Random.Range(0, enemyVariants.Length); 
            GameObject selectedEnemy = enemyVariants[randomIndex]; 

            // Instantiate the selected enemy variant
            Instantiate(selectedEnemy, spawnPosition, spawnRotation);
        }
        else
        {
            Debug.LogWarning("No enemy variants assigned in the array!");
        }
    }

    Vector3 GetValidSpawnPosition()
    {
        // Maximum number of attempts to find a valid spawn position
        int maxAttempts = 10;

        for (int i = 0; i < maxAttempts; i++)
        {
            // Generate a random Y position within the defined spawn area
            float spawnYPosition = Random.Range(spawnAreaMinY, spawnAreaMaxY);

            // Create the spawn position
            Vector3 spawnPosition = new Vector3(spawnXPosition, spawnYPosition, 0f);

            // Check if the spawn position is valid (no overlapping colliders)
            if (!Physics2D.OverlapCircle(spawnPosition, spawnRadiusCheck))
            {
                return spawnPosition; // Return the valid spawn position
            }
        }

        //no valid position is found after maxAttempts, return Vector3.zero
        Debug.LogWarning("Failed to find a valid spawn position for enemy.");
        return Vector3.zero;
    }


}