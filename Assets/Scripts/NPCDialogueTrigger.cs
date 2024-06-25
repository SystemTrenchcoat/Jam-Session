using UnityEngine;

public class NPCDialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueManager.StartDialogue();
        }
    }
}
