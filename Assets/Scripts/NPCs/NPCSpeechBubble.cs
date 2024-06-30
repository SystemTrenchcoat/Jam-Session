using UnityEngine;

public class NPCSpeechBubble : MonoBehaviour
{
    public GameObject speechBubble; // Reference to the speech bubble UI GameObject
    private bool playerInRange = false; // Flag to track if player is in range

    private void Start()
    {
        // Ensure speech bubble is initially hidden
        speechBubble.SetActive(false);
    }

    private void Update()
    {
        // Check if player is in range and speech bubble is not active
        if (playerInRange && !speechBubble.activeSelf)
        {
            // Show speech bubble when player is in range
            speechBubble.SetActive(true);
        }
        // Check if player is not in range and speech bubble is active
        else if (!playerInRange && speechBubble.activeSelf)
        {
            // Hide speech bubble when player is out of range
            speechBubble.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Player enters NPC's trigger range
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Player exits NPC's trigger range
            playerInRange = false;
            // Ensure speech bubble is hidden when player exits range
            speechBubble.SetActive(false);
        }
    }
}
