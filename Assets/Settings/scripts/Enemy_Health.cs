using UnityEngine;

public class Enemy_Health : MonoBehaviour
{

    public float maxHealth = 300;
    public float currentHealth;
    public GameObject Player;
    HealthBarBehaviour healthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthbar = GetComponentInChildren<HealthBarBehaviour>();
        healthbar.UpdateHealthBar(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
   public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;


        healthbar.UpdateHealthBar(currentHealth);

        if (currentHealth <= 0)
        {
            


            //destroy 


            Destroy(gameObject);

        }
    }
}