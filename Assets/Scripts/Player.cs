using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public float moveSpeed = 20;
    public LayerMask wallLayer;
    Rigidbody2D rb;
    Vector2 input = Vector2.right;
    public GameObject landParticles;
    bool hasLanded;
    public RuleTile coinTile;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
=======
    public Tilemap tilemap;
>>>>>>> 2f6947af84a0977a80a5849849f3cb4efb1759d7
>>>>>>> Stashed changes

    Sprite coinSprite;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
<<<<<<< Updated upstream
        coinTile.m_DefaultSprite = null;
=======
<<<<<<< HEAD
        coinTile.m_DefaultSprite = null;
=======
        coinSprite = coinTile.m_DefaultSprite;
        coinTile.m_DefaultSprite = null;
        tilemap.RefreshAllTiles();
    }

    void OnDestroy()
    {
        coinTile.m_DefaultSprite = coinSprite;
>>>>>>> 2f6947af84a0977a80a5849849f3cb4efb1759d7
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
<<<<<<< Updated upstream
=======
=======

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
>>>>>>> 2f6947af84a0977a80a5849849f3cb4efb1759d7
>>>>>>> Stashed changes
        }
    }
}