using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour
{

    public float maxHealth = 300;
    public float currentHealth;
    public GameObject Player;
    HealthBarBehaviour healthbar;
    private Animator animator;

    private Player_Controller playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerController = player.GetComponent<Player_Controller>();
        }

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


        playerController.AddScore(2000);
        // Trigger the destruction animation

        animator.SetTrigger("Destruction");


       
        float destructionDelay = 0.4f;
        yield return new WaitForSeconds(destructionDelay);

        // Destroy the object after the delay
        Destroy(gameObject);

    }
}