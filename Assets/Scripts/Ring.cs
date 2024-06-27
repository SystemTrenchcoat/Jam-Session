using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Ring")
        //{
        //GetComponent<SpriteRenderer>().color = Color.blue;
        //Destroy(gameObject);
        Debug.Log("col");
        //}
    }
}
