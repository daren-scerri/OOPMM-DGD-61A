using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : DefaultBullet
{

    // Start is called before the first frame update
    protected override void Start()
    {
        
        base.HorizontalProjectile();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
