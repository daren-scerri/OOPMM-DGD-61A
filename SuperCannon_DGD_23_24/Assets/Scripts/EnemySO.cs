using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]



public class EnemySO : ScriptableObject
{
    public GameObject enemyPrefab;
    public int strength;
    public int hitpoints;
    public float speed;

}
