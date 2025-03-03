using UnityEngine;

public class Asteroid_Behaviour : MonoBehaviour
{

    private Animator animator;
   
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
       
        if (collision.gameObject.tag == "Attack" || collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("Explode");
            Destroy(gameObject, 0.5f);
            
        }
    }



}


