using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Tilemap map;
    public Vector3Int pos;

    Rigidbody2D rb;
    Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var newInput = new Vector2( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (newInput != Vector2.zero && rb.velocity.magnitude < 0.1f)
        {
            input = newInput;
            transform.up = -input;
        }

        rb.velocity = input * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            print("money!");
            Destroy(other.gameObject);
        }
    }
}