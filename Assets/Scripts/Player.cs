using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 20;
    public LayerMask wallLayer;
    Rigidbody2D rb;
    Vector2 input = Vector2.right;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var newInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        var hit = Physics2D.Raycast(transform.position, input, 1f, wallLayer);
        if (newInput != Vector2.zero && hit.collider != null)
        {
            input = newInput;
            transform.right = input;
        }

        rb.velocity = input * moveSpeed;
    }
}