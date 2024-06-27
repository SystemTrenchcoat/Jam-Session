using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    //public int count = 0;
    private Rigidbody2D rb;
    private Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //count++;
        //if(Input.GetAxis("Horizontal") > Input.GetAxis("Vertical")
        //{
        //      if(Input.GetAxis("Horizantal") > 0){
        //          *change sprite to right facing using count*
        //      }else{
        //          *change sprite to left facing using count and flip*
        //         }
        // }else{
        //      if(Input.GetAxis("Vertical") > 0){  *I am not sure if 1 is up or -1 for vertical GetAxis*
        //          *Change sprite to facing up using count*
        //      }else{
        //          *Change sprite to down facing using count*
        //      }
        //}
        //if(count >= 4){
        //  count = 0;
        //}
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
