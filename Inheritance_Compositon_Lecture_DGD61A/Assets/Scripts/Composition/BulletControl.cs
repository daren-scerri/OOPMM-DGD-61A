using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    
    Rigidbody2D rb;
    private FireUp gunFire;
    // Start is called before the first frame update
    void Start()
    {
        gunFire = GetComponent<FireUp>();
        rb = GetComponent<Rigidbody2D>();
       
        if (gunFire != null) gunFire.Fire(rb);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
