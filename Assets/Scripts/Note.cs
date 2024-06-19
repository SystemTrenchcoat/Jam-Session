using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Holds note information
/// </summary>
public class Note
{
    public static char note1 = 'E';
    public static char note2 = 'A';
    public static char note3 = '_';

    public static KeyCode note1key = KeyCode.E;
    public static KeyCode note2key = KeyCode.A;
    public static KeyCode note3key = KeyCode.Space;

    public char note;
    public float length;
    public float time;

    public Note(char note, float time)
    {
        this.note = note;
        this.time = time;
    }

    public static Note findLastNote(List<Note> notes, char note)
    {
        Note n = null;

        for (int i = notes.Count - 1; i >= 0; i--)
        {
            if (notes[i].note == note)
            {
                n = notes[i];
                Debug.Log(n);
                break;
            }
        }

        return n;
    }

    public override string ToString()
    {
        return note + "," + length + "," + time;
    }

    public void setLength(float length)
    {
         this.length = length;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
