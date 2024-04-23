using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnTrigger2D : MonoBehaviour
{
    // The tag of the player object
    public string playerTag = "Player";

    // Trigger detection method for 2D
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            RestartGame();
        }
    }

    // Method to reload the current scene
    void RestartGame()
    {
        // Get the current active scene and reload it
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
