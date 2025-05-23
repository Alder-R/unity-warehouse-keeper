using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string gameScene;
    public void GameQuit()
    {
        Application.Quit();
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(gameScene);
    }
}
