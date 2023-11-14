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
    protected virtual void Start()
    {     
        Vector2 bulletDirection = new Vector2(GameData.MousePos.x, GameData.MousePos.y + 5f);
        Debug.Log("Bullet direction not normalized: " + bulletDirection);
        bulletDirection.Normalize();
        Debug.Log("Bullet direction normalized: " + bulletDirection);
        GetComponent<Rigidbody2D>().velocity = bulletDirection * speed;
    }

    /* Add a new method to :
 * 
 * 1. apply a force on the horizontal axis
 * 2. set the gravity to 0.98
 */



    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
