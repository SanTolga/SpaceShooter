using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bullet; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }

        void Shoot()
        {
            Instantiate(bullet, FirePoint.position, FirePoint.rotation); 
        }
    }
    
}
