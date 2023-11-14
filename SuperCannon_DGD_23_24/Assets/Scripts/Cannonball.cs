using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : DefaultBullet
{

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        HorizontalProjectile();
        
    }

    protected void HorizontalProjectile()
    {
        rb.gravityScale = 0.98f;
       // Vector2 myforce = new Vector2(speed, 0f);
       // rb.AddForce(myforce);
    }


}
