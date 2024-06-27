using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpriteController : MonoBehaviour
{

    [SerializeField] public Sprite[] sprites;
    public int count;
    private SpriteRenderer spriterenderer;


    public void Start()
    {
        count = 0;
    }

    void Update()
    {
        spriterenderer.sprite = sprites[count];
        count++;
        if (sprites[count + 1] != null)
        {
            count = 0;
        }
    }
}