using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUp : MonoBehaviour
{
    
    public void Fire(Rigidbody2D rb, float yspeed)
    {
        Vector2 myforce = new Vector2(0, yspeed);
        rb.AddForce(myforce);
    }
}
