using UnityEngine;

public class GravityController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private Vector2[] gravityDirections = { Vector2.down, Vector2.up, Vector2.left, Vector2.right };
    private int gravityIndex = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Physics2D.gravity = gravityDirections[gravityIndex] * 9.81f;
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityIndex = (gravityIndex + 1) % gravityDirections.Length;
            Physics2D.gravity = gravityDirections[gravityIndex] * 9.81f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
