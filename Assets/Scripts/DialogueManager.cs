using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public string[] dialogueLines;
    private int currentLine = 0;
    [HideInInspector] public bool isDialogueActive = false;

    private void Start()
    {
        dialogueBox.SetActive(false);
    }

    private void Update()
    {
        if (isDialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextLine();
        }
    }

    public void StartDialogue()
    {
        isDialogueActive = true;
        dialogueBox.SetActive(true);
        currentLine = 0;
        dialogueText.text = dialogueLines[currentLine];
    }

    private void DisplayNextLine()
    {
        currentLine++;
        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
        }
        else
        {
            EndDialogue();
        }
    }

    public void ResetDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false);
        currentLine = 0;
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false);
        SceneManager.LoadScene("JamTest");
    }
}
