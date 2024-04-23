using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target; // The target to follow
    public float speed = 5f; // Speed at which this sprite moves towards the target
    public float rotationSpeed = 360f; // Optional: Speed at which the sprite rotates to face the target
    public bool rotateTowardsTarget = true; // Whether to rotate towards the target

    void Update()
    {
        if (target != null)
        {
            // Get the direction to the target
            Vector3 direction = (target.position - transform.position).normalized;

            // Move towards the target
            transform.position += direction * speed * Time.deltaTime;

            if (rotateTowardsTarget)
            {
                // Calculate the angle between the current direction and the target
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

                // Smoothly rotate towards the target
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angle), rotationSpeed * Time.deltaTime);
            }
        }
    }
}
