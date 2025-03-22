using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_scene: MonoBehaviour
{
    public Button StartGame, QuitGame, Option;
    void Start()
    {
        StartGame.onClick.AddListener(OpenStartGame);
        QuitGame.onClick.AddListener(OpenQuitGame);
        Option.onClick.AddListener(OpenOption);
    }
    // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
    void OpenStartGame()
    {
        SceneManager.LoadScene("Cinematique");
    }
    void OpenOption()
    {
        SceneManager.LoadScene("Option");
    }
    
    void OpenQuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
