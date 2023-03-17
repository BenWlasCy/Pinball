using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    [SerializeField] int lives = 3;
    [SerializeField] Image[] livesUI;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameSaveManager saveManager;
    [SerializeField] GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateLives()
    {
        lives -= 1;
        for (int index = 0; index < livesUI.Length; index++)
        {
            if (index < lives)
            {
                livesUI[index].enabled = true;
            }
            else
            {
                livesUI[index].enabled = false;
            }
        }
        if (lives <= 0)
        {
            //int currentScore = gameState.getScore();
            //saveManager.LoadFromDisk();
            //int oldScore = gameState.getScore();
            //if (oldScore >= currentScore)
            //{
            //    gameState.score = currentScore;
            //}
            //else
            //{
            //    gameState.score = oldScore;
            //}
            saveManager.SaveToDisk();
            gameOverPanel.SetActive(true);
        }
    }
}
