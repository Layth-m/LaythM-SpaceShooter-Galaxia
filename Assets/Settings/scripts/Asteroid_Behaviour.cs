using UnityEngine;

public class Asteroid_Behaviour : MonoBehaviour
{
    float speed = 3f;
    private Animator animator;
   
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);
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


