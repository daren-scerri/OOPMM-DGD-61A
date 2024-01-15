using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBehaviour : MonoBehaviour, ITakeDamage
{
 public void ApplyDamage(int hitpoints)
    {
        //GameData.Score += hitpoints;
        //Debug.Log("Score: " + GameData.Score.ToString());
        GameManager.Instance.OnEnemyDie();
        Destroy(this.gameObject);
    }
}
