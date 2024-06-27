using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    public int count = 0;
    private int frames = 0;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    [SerializeField] private Sprite[] spriteHorizontal;
    [SerializeField] private Sprite[] spriteUp;
    [SerializeField] private Sprite[] spriteDown;
    [SerializeField] private Sprite[] spriteIdle;
    private SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       
        frames++;
        if (Input.GetAxis("Horizontal") != 0 && frames >= 50)
        {
            if(Input.GetAxis("Horizontal") > 0)
            {
                spriterenderer.flipX = false;
                spriterenderer.sprite = spriteHorizontal[count];
                
            }
            else
            {
                spriterenderer.flipX = true;
                spriterenderer.sprite = spriteHorizontal[count];
                
            }
            count++;
            frames = 0;
        }
        else if (Input.GetAxis("Vertical") != 0 && frames >= 50)
        {
              spriterenderer.flipX = false;
              if(Input.GetAxis("Vertical") > 0)
              {
                  spriterenderer.sprite = spriteUp[count];
              }
              else
              {
                  spriterenderer.sprite = spriteDown[count];
              }
              count++;
              frames = 0;
        }
        else if(frames >= 50)
        {
            spriterenderer.sprite = spriteIdle[count];
            frames = 0;
            if (count >= 3)
            {
                count = 0;
            }
            else
            {
                count++;
            }
        }

        if(count >= 4)
        {
          count = 0;
        }
       
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
