using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{
    public void FireCannon(GameObject mybullet)
    {
        if (mybullet != null)
        {
            Instantiate(mybullet, this.transform.position, this.transform.rotation);
        }
    }
}
