using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public int score;
    [SerializeField] TMP_Text scoreText;
    void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("GameState");

        if (objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        }
    }
    public void UpdateScore(int points)
    {
        score += points;
    }
    public void ResetCurrentScore()
    {
        score = 0;
    }
    public int getScore()
    {
        return score;
    }
}