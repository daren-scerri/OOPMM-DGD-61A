using System.Collections.Generic;
using UnityEngine;



public interface ITakeDamage
{
    public void ApplyDamage(int hitpoints);
}




public class Enemy : MonoBehaviour
{
    public int hitpoints;
    public int start_strength;
    public float start_speed;
    Animator animator;

    public int _strength;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _strength = start_strength;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Floor"))
        {
            GameData.PlayerHealth--;
            Debug.Log("Player health: " + GameData.PlayerHealth.ToString());
            Destroy(this.gameObject);

        }

        if (other.gameObject.tag == "Bullet")
        {
            animator.SetBool("RotTrigger", true);
            GetComponent<ITakeDamage>().ApplyDamage(hitpoints);
            Invoke("StopRotation", 1f);
        }

    }


    private void StopRotation()
    {
        animator.SetBool("RotTrigger", false);
    }
}