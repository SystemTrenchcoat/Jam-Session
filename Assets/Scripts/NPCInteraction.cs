using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCInteraction : MonoBehaviour
{
    public string minigameSceneName = "RhythmMinigameScene"; // Name of the rhythm minigame scene

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E)) // Change "Player" tag to match your player's tag
        {
            // Load the rhythm minigame scene
            SceneManager.LoadScene(minigameSceneName);
        }
    }
}
