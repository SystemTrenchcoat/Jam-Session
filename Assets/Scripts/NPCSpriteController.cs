using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpriteController : MonoBehaviour
{

    [SerializeField] public Sprite[] sprites;
    public int count;
    private SpriteRenderer spriterenderer;


    public void start()
    {
        count = 0;
    }

    void update()
    {
        spriterenderer.sprite = sprites[count];
        count++;
        if (sprites[count + 1] != null)
        {
            count = 0;
        }
    }
}