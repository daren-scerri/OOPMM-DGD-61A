using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehaviour: MonoBehaviour, ITakeDamage
{

public void ApplyDamage(int  hitpoints)
    {
        Enemy _enemy = GetComponent<Enemy>();
        _enemy._strength--;
        StartCoroutine(ApplyDamageEffect());
        if (_enemy._strength <= 0)
        {
            GameData.Score += hitpoints;
            Debug.Log("Score: " + GameData.Score.ToString());
            Destroy(this.gameObject);
        }
    }

    IEnumerator ApplyDamageEffect()
    {
       
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

       Color enemyColor = spriteRenderer.color;
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.2f);

        // Reset the color back to normal (you can adjust the color as needed)
        spriteRenderer.color = enemyColor;
    }
}

