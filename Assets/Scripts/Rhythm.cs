using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Unity.VisualScripting;

/// <summary>
/// Creates the notes that in the jam session
/// Needs to be placed on the Rhythm Vizualizer in order to work correctly
/// </summary>
public class Rhythm : MonoBehaviour
{
    public GameObject shortNotePrefab;
    public GameObject longNotePrefab;
    public GameObject duoNotePrefab;

    public AudioSource audio;
    public List<GameObject> song;
    public float delay;
    public float timer = 0.06f;
    public int noteCount = 0;
    public void ImportSong(string path)
    {
        StreamReader sr = new StreamReader(path);
        string text;
        float bpm = 60;

        do
        {
            text = sr.ReadLine();
            if (float.TryParse(text, out float t))
            {
                bpm = t;
                delay = bpm / 60;
                Debug.Log(delay);
            }
            else if (text != null)
            {
                GameObject note;
                if (float.Parse(text.Split(',')[1]) <= 1.2f)
                {
                    note = shortNotePrefab;
                }
                else
                {
                    note = longNotePrefab;
                }

                note.GetComponent<Note>().GenerateNote(text, bpm);
                song.Add(GameObject.Instantiate(note));
                note.GetComponent<Note>().prefab = note;
                song[song.Count - 1].SetActive(false);
                Debug.Log(note.GetComponent<Note>().ToString() + " " + song.Count);
            }
            Debug.Log(text);
        } while (text != null);
        sr.Close();
        Debug.Log(song[0].GetComponent<Note>().ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        song = new List<GameObject>();
        ImportSong("Assets/Text/Reggae.txt");
        //delay = 2;
        Debug.Log(song.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (noteCount < song.Count && timer >= song[noteCount].GetComponent<Note>().time)
        {
            if (timer >= delay + song[0].GetComponent<Note>().time && !audio.isPlaying)
            {
                audio.Play();
            }
            song[noteCount].SetActive(true);
            Debug.Log(song[noteCount].GetComponent<Note>().note + " " + song[noteCount].GetComponent<Note>().time);
            noteCount++;
        }

        timer += Time.deltaTime;
    }

    //    void PlaySong(string song)
    //    {

    //    }
}
