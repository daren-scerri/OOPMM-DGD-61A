using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : DefaultBullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        rb.drag = 0.5f;    
    }





 
}
