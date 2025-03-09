using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour
{

    public float maxHealth = 300;
    public float currentHealth;
    public GameObject Player;
    HealthBarBehaviour healthbar;
    private Animator animator;
   
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthbar = GetComponentInChildren<HealthBarBehaviour>();
        healthbar.UpdateHealthBar(currentHealth);
        animator = GetComponent<Animator>();
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
            
            StartCoroutine(WaitForAnimationAndTransition());
          

        }
    }

    private IEnumerator WaitForAnimationAndTransition()
    {

        // Disable other scripts or components
       // GetComponent<Collider>().enabled = false; // Disable collider
       // GetComponent<Enemy_Behaviour>().enabled = false; // Disable movement script

        // Trigger the destruction animation
       
            animator.SetTrigger("Destruction");


        // Wait for the specified delay (or use animation length)
        float destructionDelay = 0.4f;
        yield return new WaitForSeconds(destructionDelay);

        // Destroy the object after the delay
        Destroy(gameObject);

    }
}