using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

/// <summary>
/// Holds note information
/// </summary>
public class Note : MonoBehaviour
{
    public static Vector2 track1 = new Vector2(-1f, 0);//math.sqrt(80) / 10000000);
    public static Vector2 track2 = new Vector2(-1f, 0);
    public static Vector2 track3 = new Vector2(-1f, 0); //math.sqrt(3) / 2, -.45f);//-.5f, -math.sqrt(3) / 2);

    public static char note1 = 'E';
    public static char note2 = 'A';
    public static char note3 = '_';

    public static KeyCode note1key = KeyCode.E;
    public static KeyCode note2key = KeyCode.A;
    public static KeyCode note3key = KeyCode.Space;

    public static int rotation = 26;

    public bool stop = false;
    public char note;
    public float length;
    public float time;
    public float speed = .004f;
    public Vector2 track;

    public GameObject prefab;

    public void GenerateNote(string info, float bpm)
    {
        string[] lines = info.Split(',');

        note = lines[0][0];
        length = float.Parse(lines[1]);
        time = float.Parse(lines[2]);
        speed = bpm / 1800;// / 2;
        //UnityEngine.Debug.Log(speed);
    }

    public override string ToString()
    {
        return note + "," + length + "," + time;
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }
    public void setPrefab()
    {
        if (note == note1)
        {
            prefab.transform.Rotate(0, 0, -rotation);
            track = track1;
        }
        else if (note == note2)
        {
            prefab.transform.Rotate(0, 0, 3);
            track = track2;
        }
        else if (note == note3)
        {
            prefab.transform.Rotate(0, 0, rotation);
            track = track3;
        }
        UnityEngine.Debug.Log(prefab.name);
        //prefab.gameObject.
    }

    // Start is called before the first frame update
    void Start()
    {
        if (note == note1)
        {
            track = track1;
            prefab.transform.Rotate(0, 0, -rotation);
            //UnityEngine.Debug.Log("Track 1");
        }
        else if (note == note2)
        {
            track = track2;
            prefab.transform.Rotate(0, 0, 3);
            //UnityEngine.Debug.Log("Track 2");
        }
        else if (note == note3)
        {
            track = track3;
            prefab.transform.Rotate(0, 0, rotation);
           //UnityEngine.Debug.Log("Track 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
            transform.Translate(speed * track);
        //UnityEngine.Debug.Log(speed * track);
    }
}
