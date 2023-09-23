using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Rigidbody2D _rb;
    public float BulletSpeed;
    public float destroytime;
    public GameObject circle; 
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = transform.up * BulletSpeed;
        Destroy(gameObject, 2f); 
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
}
