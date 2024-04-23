using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float minYLevel = -10f; // Define the minimum Y level to trigger game restart

    // Update is called once per frame
    void Update()
    {
        // Check if the player's Y position is below the minimum level
        if (transform.position.y < minYLevel)
        {
            RestartGame(); // Call the function to restart the game
        }
    }

    void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
