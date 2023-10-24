using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour
{
    Enemy bob, alice; // declare bob and alice
    int playerHP = 10;
    int playerDamage = 3; //This is our damage power
    void Start()
    {
        bob = new Enemy(50, 2, "Bob"); //Bob has 5 hp, 2 damage, and a name of Bob
        alice = new Enemy(20, 5, "Alice"); //Alice has 2 hp, 5 damage, and a name of Alice
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            bob.TakeDamage(playerDamage);
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            alice.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= bob.damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= alice.damage;
            Debug.Log("Player HP: " + playerHP);
        }


        if (playerHP < 1)
        {
            //if our hp is under 1, we die
            Debug.Log("You Died!");
            QuitGame();
        }

        if (playerHP < 1)
        {
            //if our hp is under 1, we die
            Debug.Log("You Died!");
            QuitGame();
        }

        if (bob.hitpoints < 1 && alice.hitpoints < 1)
        {
            //if our hp is under 1, we die
            Debug.Log("Player Wins!");
            QuitGame();
        }


    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }


}
