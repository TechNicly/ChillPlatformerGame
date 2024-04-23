using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves horizontally
    public float acceleration = 10f; // Acceleration rate for smoother movement transitions
    public float deceleration = 10f; // Deceleration rate for smoother stopping transitions
    public bool smoothMovement = true; // Whether to use smoother transitions
    public KeyCode leftKey = KeyCode.A; // Key for moving left
    public KeyCode rightKey = KeyCode.D; // Key for moving right

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from the horizontal axis
        float horizontalInput = 0f;

        if (Input.GetKey(leftKey))
        {
            horizontalInput = -1f; // Move left
        }
        else if (Input.GetKey(rightKey))
        {
            horizontalInput = 1f; // Move right
        }

        Move(horizontalInput);
    }

    void Move(float horizontalInput)
    {
        if (smoothMovement)
        {
            // Smooth acceleration and deceleration
            float targetVelocityX = horizontalInput * moveSpeed;
            float currentVelocityX = rb.velocity.x;

            float smoothChange = Mathf.Lerp(currentVelocityX, targetVelocityX, acceleration * Time.deltaTime);

            rb.velocity = new Vector2(smoothChange, rb.velocity.y); // Apply horizontal velocity
        }
        else
        {
            // Instant movement without smooth transitions
            rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y); // Apply horizontal velocity
        }
    }
}
