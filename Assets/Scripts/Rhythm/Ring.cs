using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Rhythm rhyth;

    private void Start()
    {
        rhyth = GameObject.FindGameObjectWithTag("Rhyth Visualizer").GetComponent<Rhythm>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            //Debug.Log("Note");

            //Note 1
            if (collision.GetComponent<Note>().note == Note.note1)
            {
                if (Input.GetKeyDown(Note.note1key) || Input.GetKey(Note.note1key))
                {
                    //Debug.Log("Play 1");
                    NoteDestroy(collision.gameObject, Note.note1key);
                }
            }

            //Note 2
            if (collision.GetComponent<Note>().note == Note.note2)
            {
                if (Input.GetKeyDown(Note.note2key) || Input.GetKey(Note.note2key))
                {
                    //Debug.Log("Play 2");
                    NoteDestroy(collision.gameObject, Note.note2key);
                }
            }

            //Note 3
            if (collision.GetComponent<Note>().note == Note.note3)
            {
                if (Input.GetKeyDown(Note.note3key) || Input.GetKey(Note.note3key))
                {
                    //Debug.Log("Play 3");
                    NoteDestroy(collision.gameObject, Note.note3key);
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            //Debug.Log("Note");

            //Note 1
            if (collision.GetComponent<Note>().note == Note.note1)
            {
                if (Input.GetKeyDown(Note.note1key) || Input.GetKey(Note.note1key))
                {
                    //Debug.Log("Play 1");
                    NoteDestroy(collision.gameObject, Note.note1key);
                }
            }

            //Note 2
            if (collision.GetComponent<Note>().note == Note.note2)
            {
                if (Input.GetKeyDown(Note.note2key) || Input.GetKey(Note.note2key))
                {
                    //Debug.Log("Play 2");
                    NoteDestroy(collision.gameObject, Note.note2key);
                }
            }

            //Note 3
            if (collision.GetComponent<Note>().note == Note.note3)
            {
                if (Input.GetKeyDown(Note.note3key) || Input.GetKey(Note.note3key))
                {
                    //Debug.Log("Play 3");
                    NoteDestroy(collision.gameObject, Note.note3key);
                }
            }
        }
    }

    private void NoteDestroy(GameObject note, KeyCode key)
    {
        if (note.GetComponent<Note>().length <= 1.2f)// && Input.GetKeyDown(key))
        {
            Destroy(note);
        }

        else
        {
            Debug.Log("Long");
            note.GetComponent<Note>().stop = false;
            if (note.GetComponent<Transform>().localScale.x > 0)
            {
                note.GetComponent<Note>().stop = true;
                note.GetComponent<Transform>().localScale = new Vector3(note.GetComponent<Transform>().localScale.x -
                    (note.GetComponent<Note>().length * note.GetComponent<Note>().speed), 2, 0);
                Debug.Log(note.GetComponent<Transform>().localScale.x);
            }
            else
            {
                Debug.Log("Destroy");
                Destroy(note);
            }
        }
    }
}
