using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] List<Button> buttons; // List of buttons

    // Start is called before the first frame update
    void Start()
    {
        foreach (var button in buttons)
        {
            // Assuming button names are "Start" and "Exit" for respective functionality
            if (button.name == "Start")
            {
                button.onClick.AddListener(StartGame);
            }
            else if (button.name == "Exit")
            {
                button.onClick.AddListener(QuitGame);
            }

            // Add a generic listener for all buttons
            button.onClick.AddListener(() => PrintMsg(button.name));
        }
    }

    void StartGame()
    {
        Debug.Log("You have clicked the start button");
        SceneManager.LoadScene("GameScene");
    }

    void QuitGame()
    {
        Debug.Log("You have clicked the exit button");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
        Application.OpenURL(webplayerQuitURL);
#else
        Application.Quit();
#endif
    }

    void PrintMsg(string buttonName)
    {
        Debug.Log(buttonName + " has been clicked");
    }
}

