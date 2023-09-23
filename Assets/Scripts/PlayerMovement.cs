using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    public Rigidbody2D rb;
    public Vector2 movement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); 
    }

    private void FixedUpdate()
    {
         rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
