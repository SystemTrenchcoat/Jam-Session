using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    private SpriteRenderer spriterenderer;
    private Animator animationController;
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>(); 
        animationController = GetComponent<Animator>();
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(Input.GetAxis("Horizontal") < 0) 
            spriterenderer.flipX = true;
    
        else
            spriterenderer.flipX = false;

        animationController.SetFloat("PosX", Input.GetAxisRaw("Horizontal"));
        animationController.SetFloat("PoxY", Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
