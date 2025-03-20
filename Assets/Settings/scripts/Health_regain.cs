using UnityEngine;

public class Health_regen : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

          //  Instantiate(VFX_HitPlayer, transform.position, Quaternion.identity);

            var healthComponent = collision.gameObject.GetComponent<playerHealth>();
            healthComponent.HealDamage(100f);
            Destroy(gameObject);
        }
    }
}
