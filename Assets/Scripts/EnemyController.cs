using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D _rb;
    public float EnemySpeed;
   public GameObject enemy;
    

    private void Start()
    {
        InvokeRepeating("Spawn", 3f, 8f); 
        EnemyWalk();
    }

    void Spawn()
    {
        Instantiate(enemy, new Vector2(Random.Range(-7f, 7), Random.Range(6f, 6)), Quaternion.identity);
    }

    private void EnemyWalk()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.down * EnemySpeed; 
    }
}