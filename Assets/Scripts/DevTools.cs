using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    public Dictionary<string, Dictionary<float, char>> songbook;
    public Dictionary<float, char> activeSong;

    // Start is called before the first frame update
    void Start()
    {
        songbook = new Dictionary<string, Dictionary<float, char>>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetSongNotes("Song " + songbook.Count + 1);
        }
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
    }

    void StopSettingNotes()
    {
        activeSong = null;
    }

    void PlaySong(string song)
    {
        //songbook[song]
    }
}
