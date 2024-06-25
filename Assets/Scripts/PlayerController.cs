using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //if(Input.GetAxis("Horizontal") > Input.GetAxis("Vertical")
        //{
        // if(Input.GetAxis("Horizantal") > 0){
        // *change sprite to right facing*
        //}else{
        // *change sprite to left facing*
        // }
        // }else{
        //  if(Input.GetAxis("Vertical") > 0){  *I am not sure if 1 is up or -1 for vertical GetAxis*
        //  *Change sprite to facing up*
        // }else{
        //  *Change sprite to down facing*
        // }
        //}
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
