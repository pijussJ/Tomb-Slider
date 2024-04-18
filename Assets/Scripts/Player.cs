using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject landParticles;
    public float speed = 5;
    Rigidbody2D rb;
    Vector2 input = Vector2.left;
    public bool hasLanded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var newInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (rb.velocity.magnitude < 0.1f && newInput != Vector2.zero)
        {
            input = newInput;
            transform.up = -input;
        }
        rb.velocity = input * speed;
    }
}