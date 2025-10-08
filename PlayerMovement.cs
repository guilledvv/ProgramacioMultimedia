using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad del personaje
    public float jumpForce = 7f; // Fuerza del salto

    private Rigidbody2D rb;
    private Collider2D coll;

    private float moveInput;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        moveInput = Input.GetAxisRaw("Horizontal"); // A/D o flechas

        // Comprobar si estamos en el suelo
        isGrounded = CheckGrounded();

        // Salto con W o flecha arriba
        if (isGrounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        // Mover personaje
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private bool CheckGrounded()
    {
        // Devuelve true si el collider toca algo con tag "Ground"
        ContactPoint2D[] contacts = new ContactPoint2D[10];
        int contactCount = coll.GetContacts(contacts);

        for (int i = 0; i < contactCount; i++)
        {
            if (contacts[i].collider.CompareTag("Ground"))
            {
                return true;
            }
        }
        return false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Recolectable"))
        {
            Destroy(other.gameObject); // El objeto desaparece al recogerlo
        }
    }
}
