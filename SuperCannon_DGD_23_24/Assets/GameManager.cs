using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{ 
[SerializeField] Text playerScoreText;

[SerializeField] Text healthText;

SaveLoadManager mySaveLoadManager;

// Use this for initialization
void Start()
{
    mySaveLoadManager = new SaveLoadManager();
    GameData.Score = 0;
    GameData.PlayerHealth = 20;
    mySaveLoadManager.LoadData();
    playerScoreText.text = "Score: " + GameData.Score.ToString();
    healthText.text = "Health: " + GameData.PlayerHealth.ToString();
}

public void OnEnemyDie()
{

    GameData.Score++;
    playerScoreText.text = "Score: " + GameData.Score.ToString();
    mySaveLoadManager.SaveData();
}

//public void OnFixedEnemyDie()
//{
//    mySaveLoadManager.DeleteFile();
//    SceneManager.LoadScene("Win");

//}

public void PlayerDamage()
{
    GameData.PlayerHealth--;
    mySaveLoadManager.SaveData();
    healthText.text = "Health: " + GameData.PlayerHealth.ToString();
    if (GameData.PlayerHealth <= 0) 
    {
        mySaveLoadManager.DeleteFile();
        SceneManager.LoadScene("GameOver");
    }

}


}
