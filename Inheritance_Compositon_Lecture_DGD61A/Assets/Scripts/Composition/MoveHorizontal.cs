using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    [SerializeField] float xspeed;
    // Start is called before the first frame update
    public void FireProjectile(Rigidbody2D rb)
    {
        rb.gravityScale = 0.98f;
        Vector2 myforce = new Vector2(xspeed, 0f);
        rb.AddForce(myforce);
    }


}
