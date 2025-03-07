using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public float maxHealth = 1000;
    public float currentHealth;

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

   public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;


        healthbar.UpdateHealthBar(currentHealth);

      //  if (currentHealth <= 0)
      //  {
           
            //animate
            //destroy 
            //gameover

      //  }
    }
}
