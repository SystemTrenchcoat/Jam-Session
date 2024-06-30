using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/// <summary>
/// Dev tools to make development easier and more fun
/// Always placec on Rhythm Visualizer
/// </summary>
public class DevTools : MonoBehaviour
{
    public Dictionary<string, List<NoteInfo>> songbook;
    public List<NoteInfo> activeSong;
    public string songName;
    public bool setSong;
    public float bpm;
    public AudioSource audio;
    public float timer;
    public float timer1;
    public float timer2;
    public float timer3;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        songbook = new Dictionary<string, List<NoteInfo>>();
        timer = 0;
        timer1 = 0;
        timer2 = 0;
        timer3 = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        //Make songs to be played
        if (/*Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && */Input.GetKeyDown(KeyCode.F3))
        {
            SetSongNotes(songName + " " + (songbook.Count + 1));
        }

        if (setSong)
        {
            //Note 1
            if (Input.GetKeyDown(Note.note1key))
            {
                activeSong.Add(new NoteInfo(Note.note1, timer + Time.deltaTime));
            }
            if (Input.GetKeyUp(Note.note1key))
            {
                NoteInfo.findLastNote(activeSong, Note.note1).setLength(timer1 + Time.deltaTime);
                timer1 = 0;
            }

            //Note 2
            if (Input.GetKeyDown(Note.note2key))
            {
                activeSong.Add(new NoteInfo(Note.note2, timer + Time.deltaTime));
            }
            if (Input.GetKeyUp(Note.note2key))
            {
                NoteInfo.findLastNote(activeSong, Note.note2).setLength(timer2 + Time.deltaTime);
                timer2 = 0;
            }

            //Note 3
            if (Input.GetKeyDown(Note.note3key))
            {
                activeSong.Add(new NoteInfo(Note.note3, timer + Time.deltaTime));
            }
            if (Input.GetKeyUp(Note.note3key))
            {
                NoteInfo.findLastNote(activeSong, Note.note3).setLength(timer3 + Time.deltaTime);
                timer3 = 0;
            }

            //Stop recording input
            if (/*Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && */Input.GetKeyDown(KeyCode.F4))
            {
                StopSettingNotes();
            }
        }
    }

    //Called every framrate frame
    void FixedUpdate()
    {
        if (setSong)
        {
            //Note 1
            if (Input.GetKey(Note.note1key))
            {
                timer1 += Time.deltaTime;
            }

            //Note 2
            if (Input.GetKey(Note.note2key))
            {
                timer2 += Time.deltaTime;
            }

            //Note 3
            if (Input.GetKey(Note.note3key))
            {
                timer3 += Time.deltaTime;
            }
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
        List<NoteInfo> notes = new List<NoteInfo>();

        songbook[song] = notes;
        activeSong = notes;
        songName = song;
        timer = 0;
        audio.Play();
        Debug.Log("Recording...");
    }

    void StopSettingNotes()
    {
        WriteSongText();
        audio.Stop();
        Debug.Log($"Stop setting notes: {activeSong}");
        activeSong = null;
        songName = songName.Remove(songName.LastIndexOf(' '));
    }

    void WriteSongText()
    {
        string path = "Assets/Text/" + songName + ".txt";
        StreamWriter sw = new StreamWriter(path);

        sw.WriteLine(bpm);

        foreach (NoteInfo n in activeSong)
        {
            sw.WriteLine(n.ToString());
        }

        sw.Close();

        Debug.Log(activeSong.Count);
        Debug.Log(path);
    }

    void PlaySong(string song)
    {
        //songbook[song]
    }
}
