using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

[RequireComponent(typeof(Rigidbody2D))]
public class BulletControl : MonoBehaviour
{
    
    Rigidbody2D rb;
    private FireUp gunFire;
    private MoveHorizontal myprojectile;
    // Start is called before the first frame update
    void Start()
    {
        gunFire = GetComponent<FireUp>();
        myprojectile = GetComponent<MoveHorizontal>();
        rb = GetComponent<Rigidbody2D>();

        if (gunFire != null) gunFire.Fire(rb);

        try
        {
           myprojectile.FireProjectile(rb);
        }
        catch (NullReferenceException ex)
        {
            Debug.Log(this.gameObject.name +" has no horizontal firing");
        }


        // Update is called once per frame
    } 
}
