using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static Level iLevel;
    public int boxNum = 9999;
    [SerializeField] List<Levels> levels;
    public int currentLevel = 0;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameManager gameManager;

    void Start()
    {
        iLevel = this;
        boxNum = levels[currentLevel].boxNum;
    }

    void Update()
    {
        if (boxNum == 0)
        {
            if (++currentLevel == levels.Count)
            {
                currentLevel = 0;
                gameManager.GameRestart();
            }
            else
            {
                mainCam.transform.Translate(Vector3.right * 100);
            }
            boxNum = levels[currentLevel].boxNum;
            Player.iPlayer.gameObject.transform.position = levels[currentLevel].startPos;
        }
    }
}

[System.Serializable]
class Levels
{
    public int boxNum;
    public Vector3 startPos;
}