using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 20;
    public LayerMask wallLayer;
    Rigidbody2D rb;
    Vector2 input = Vector2.right;
    public GameObject landParticles;
    bool hasLanded;
    public RuleTile coinTile;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coinTile.m_DefaultSprite = null;
    }

    void Update()
    {
        var newInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        var hit = Physics2D.Raycast(transform.position, input, 1f, wallLayer);
        if (newInput != Vector2.zero && hit.collider != null && newInput != input)
        {
            input = newInput;
            transform.up = -input;
            hasLanded = false;
        }

        // land particles
        if (rb.velocity.magnitude < 0.1f && !hasLanded)
        {
            hasLanded = true;
            var obj = Instantiate( landParticles, transform.position, Quaternion.identity);
            obj.transform.up = transform.up;
        }


        rb.velocity = input * moveSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }
}