using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class DefaultBullet : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody2D rb;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    protected virtual void OnEnable()
    {     
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    /* Add a new method to :
 * 
 * 1. apply a force on the horizontal axis
 * 2. set the gravity to 0.98
 */



    private void OnBecameInvisible()
    {
       // Destroy(this.gameObject);   Instead of Destroy when we use object pooling we set the bullet back to inactive (goes back in the pool)
       this.gameObject.SetActive(false);
    }


}
