using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpriteController : MonoBehaviour
{

    [SerializeField] public Sprite[] sprites;
    public int count;
    private SpriteRenderer spriterenderer;


    private void Start()
    {
        count = 0;
    }

    private void Update()
    {
        spriterenderer.sprite = sprites[count];
        count++;
        if (sprites[count++] == null)
        {
            count = 0;
        }
    }
}