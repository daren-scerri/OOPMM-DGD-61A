using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour
{
    GameObject bob, alice; // declare bob and alice
    int playerHP = 10;
    int playerDamage = 3; //This is our damage power
    Enemy _bob_instance, _alice_instance;

    void Start()
    {
        bob = Instantiate(Resources.Load("Bob"), new Vector3(-2f, 0f, 0f), Quaternion.identity) as GameObject; 
        alice = Instantiate(Resources.Load("Alice"), new Vector3(2f, 0f, 0f), Quaternion.identity) as GameObject; //Alice has 2 hp, 5 damage, and a name of Alice
        _bob_instance = bob.GetComponent<Enemy>();
        _alice_instance = alice.GetComponent<Enemy>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            _bob_instance.TakeDamage(playerDamage);
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            _alice_instance.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= _bob_instance.damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= _alice_instance.damage;
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

        if (_bob_instance.hitpoints < 1 && _alice_instance.hitpoints < 1)
        {
            //if our hp is under 1, we die
            Debug.Log("Player Win!");
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
