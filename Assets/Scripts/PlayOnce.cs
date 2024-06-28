using UnityEngine;

public class PlayAudioOnce : MonoBehaviour
{
    public AudioClip audioClip; // Assign your audio clip in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioClip != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
        else
        {
            Debug.LogWarning("AudioClip not assigned.");
        }
    }
}