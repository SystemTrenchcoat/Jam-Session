using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds note information
/// </summary>
public class Note : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
