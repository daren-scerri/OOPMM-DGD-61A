using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    [SerializeField] float yspeed;
    Rigidbody2D rb;
    private FireUp gunFire;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gunFire = new FireUp();
        gunFire.Fire(rb, yspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
