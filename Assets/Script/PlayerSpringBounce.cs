using UnityEngine;

public class PlayerSpringBounce : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spring"))
        {
            ContactPoint2D contact = collision.contacts[0];
            Vector2 normal = contact.normal;
            Vector2 currentVelocity = rb.linearVelocity;
            Vector2 reflectedVelocity = Vector2.Reflect(currentVelocity, normal);
            rb.linearVelocity = reflectedVelocity;

            Debug.Log("Player bounced off the spring with velocity: " + reflectedVelocity);
        }
    }
}
