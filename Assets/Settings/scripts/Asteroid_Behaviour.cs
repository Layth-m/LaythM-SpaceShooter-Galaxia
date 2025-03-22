using UnityEngine;
using UnityEngine.InputSystem;



public class Asteroid_Behaviour : MonoBehaviour
{
    float speed = 3f;
    private Animator animator;
    private Player_Controller playerController; 
    
    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerController = player.GetComponent<Player_Controller>();
        }

        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -9.15f || transform.position.y < -5.4f || transform.position.y > 7.25f)
        {

            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if( collision.gameObject.tag == "Attack")
        {
            animator.SetTrigger("Explode");
            playerController.AddScore(500);
            Destroy(gameObject, 0.5f);
        }


        if ( collision.gameObject.tag == "Player")
        {
            var healthComponent = collision.gameObject.GetComponent<playerHealth>();
            Debug.LogError("collision detacted");

            healthComponent.TakeDamage(50f);

            animator.SetTrigger("Explode");
            playerController.AddScore(500);
            Destroy(gameObject, 0.5f);
            
        }
    }



}


