using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/// <summary>
/// Creates the notes that in the jam session
/// Needs to be placed on the Rhythm Vizualizer in order to work correctly
/// </summary>
public class Rhythm : MonoBehaviour
{
    public List<Note> song;
    public float delay;
    public float timer;

    public void ImportSong(string path)
    {
        StreamReader sr = new StreamReader(path);
        string text;

        do
        {
            text = sr.ReadLine();
            song.Add(new Note(text));
        } while (text != null);
        sr.Close();
    }

    // Start is called before the first frame update
    void Start()
    {
        song = new List<Note>();
        delay = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

//    void PlaySong(string song)
//    {
        
//    }
}
