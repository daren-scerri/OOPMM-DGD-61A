using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUp : MonoBehaviour
{
    [SerializeField] float yspeed;
    public void Fire(Rigidbody2D rb)
    {
        Vector2 myforce = new Vector2(0, yspeed);
        rb.AddForce(myforce);
    }
}
