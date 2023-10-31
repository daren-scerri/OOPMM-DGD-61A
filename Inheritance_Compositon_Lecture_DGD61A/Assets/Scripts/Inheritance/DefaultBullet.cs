using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class DefaultBullet : MonoBehaviour
{
    [SerializeField] protected float yspeed, xspeed;
    protected Rigidbody2D rb;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    protected virtual void Start()
    {     
        Vector2 myforce = new Vector2(0, yspeed);
        rb.AddForce(myforce);
    }

    /* Add a new method to :
 * 
 * 1. apply a force on the horizontal axis
 * 2. set the gravity to 0.98
 */
    protected void HorizontalProjectile()
    {
        rb.gravityScale = 0.98f;
        Vector2 myforce = new Vector2(xspeed, 0f);
        rb.AddForce(myforce);
    }


    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
