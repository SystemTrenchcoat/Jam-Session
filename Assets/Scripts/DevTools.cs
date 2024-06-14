using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dev tools to make development easier and more fun
/// Always placec on Rhythm Visualizer
/// </summary>
public class DevTools : MonoBehaviour
{
    public Dictionary<string, Dictionary<float, char>> songbook;
    public Dictionary<float, char> activeSong;
    public AudioSource audio;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        songbook = new Dictionary<string, Dictionary<float, char>>();
        timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make songs to be played
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetSongNotes("Song " + songbook.Count + 1);
        }

        //Note 1
        if (Input.GetKeyDown(KeyCode.E))
        {
            activeSong[timer + Time.deltaTime] = 'E';
        }

        //Note 2
        if (Input.GetKeyDown(KeyCode.A))
        {
            activeSong[timer + Time.deltaTime] = 'A';
        }

        //Note 3
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activeSong[timer + Time.deltaTime] = '_';
        }

        //Stop recording input
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha4))
        {
            StopSettingNotes();
        }

        timer += Time.deltaTime;
    }

    /// <summary>
    /// Make a song to be played by the player
    /// </summary>
    /// <param name="song">Audio file to be played</param>
    /// <param name="notes">When each note should be played</param>
    void SetSongNotes(string song)
    {
        Dictionary<float, char> notes = new Dictionary<float, char>();

        songbook[song] = notes;
        activeSong = notes;
        timer = 0;
        audio.Play();
        Debug.Log("Recording...");
    }

    void StopSettingNotes()
    {
        activeSong = null;
        audio.Stop();
        Debug.Log($"Stop setting notes: {activeSong}");
    }

    void PlaySong(string song)
    {
        //songbook[song]
    }
}
