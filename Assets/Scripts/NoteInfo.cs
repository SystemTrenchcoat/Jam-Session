using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInfo
{
    public char note;
    public float length;
    public float time;

    public NoteInfo(char note, float time)
    {
        this.note = note;
        this.time = time;
    }

    public void setLength(float length)
    {
        this.length = length;
    }

    public static NoteInfo findLastNote(List<NoteInfo> notes, char note)
    {
        NoteInfo n = null;

        for (int i = notes.Count - 1; i >= 0; i--)
        {
            if (notes[i].note == note)
            {
                n = notes[i];
                break;
            }
        }

        return n;
    }

    public override string ToString()
    {
        return note + "," + length + "," + time;
    }
}
