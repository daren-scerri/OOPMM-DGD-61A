using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Singleton<EnemySpawner>
{
    public List<EnemySO> enemyList = new List<EnemySO>();
    // Start is called before the first frame update

    public static EnemySpawner myEnemySpawner;





    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

 IEnumerator SpawnEnemies()
    {
        while(true)
        {
            int enemychoice = Random.Range(0, enemyList.Count);
            Vector3 enemypos = new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax);
            GameObject enemyInstance = Instantiate(enemyList[enemychoice].enemyPrefab, enemypos, Quaternion.identity);
            enemyInstance.GetComponent<Enemy>().hitpoints = enemyList[enemychoice].hitpoints;  //push data from scriptable object to instance
            enemyInstance.GetComponent<Enemy>().start_strength = enemyList[enemychoice].strength;

            yield return new WaitForSeconds(1f);
        }

    }
}
