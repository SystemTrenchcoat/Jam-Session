using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpriteController : MonoBehaviour
{

    [SerializeField] public Sprite[] sprites;
    private int count;
    private int frames;
    private SpriteRenderer spriterenderer;


    void Start()
    {
        count = 0;
        frames = 0;
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (frames == 50)
        {
            frames = 0;
            spriterenderer.sprite = sprites[count];
            count++;

            if (count >= sprites.Length)
            {
                count = 0;
            }
        }
        frames++;
    }

}
