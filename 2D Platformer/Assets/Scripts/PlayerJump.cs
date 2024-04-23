using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // Force applied to the Rigidbody2D to achieve a jump
    public float verticalVelocityThreshold = 0.1f; // Tolerance for determining if the player is grounded
    public KeyCode jumpKey = KeyCode.Space; // Key to trigger a jump

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the vertical component of the velocity is near zero
        bool isGrounded = Mathf.Abs(rb.velocity.y) < verticalVelocityThreshold;

        // Detect jump input (e.g., Space key) and check if the player is grounded
        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); // Set the upward velocity to jumpForce
    }
}
