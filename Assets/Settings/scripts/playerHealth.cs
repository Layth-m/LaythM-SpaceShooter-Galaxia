using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public float maxHealth = 1000;
    public float currentHealth;
    public GameObject VFX_Destory;
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

   if (currentHealth <= 0)
        {


            //destroy 
            Instantiate(VFX_Destory, transform.position, Quaternion.identity);

            Destroy(gameObject, 0.5f);
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");

        }
    }

    public void HealDamage(float amount)
    {
        currentHealth = currentHealth + amount;
        healthbar.UpdateHealthBar(currentHealth);
    }
}
