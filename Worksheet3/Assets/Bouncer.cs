using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] Vector2 force = new Vector2(5f, 5f);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        health -= 10;
        Color color = GetComponent<SpriteRenderer>().color;
        color.a -= 0.1f;
        GetComponent<SpriteRenderer>().color = color;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
        Debug.Log("Health: " +  health.ToString());
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
