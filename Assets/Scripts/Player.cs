using UnityEngine;

public class Player : MonoBehaviour
{
	 public float moveSpeed = 20f;
    Rigidbody2D rb;
    Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
         var newInput = new Vector2( Input.GetAxisRaw( "Horizontal" ), Input.GetAxisRaw( "Vertical" ));
         if (newInput != Vector2.zero && rb.velocity.magnitude < 0.1f)
         {
				 input = newInput;
				 transform.up = -input;
         }

         rb.velocity = input * moveSpeed;
    }

}