using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{
    public void FireCannon(GameObject mybullet)
    {
        if (mybullet != null)
        {
            //Instantiate(mybullet, this.transform.position, this.transform.rotation);

            //commented out instanitate form above and implemented object pooling by activating a bullet at the cannon tip 

            mybullet.transform.position = this.transform.position;
            mybullet.transform.rotation = this.transform.rotation;
            mybullet.SetActive(true);
        }
    }
}
