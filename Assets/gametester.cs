using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gametester : MonoBehaviour
{
    [SerializeField] InputAction IncreaseScore;
    [SerializeField] InputAction DecreaseScore;
    [SerializeField] InputAction ResetScore;
    [SerializeField] InputAction SaveScore;
    [SerializeField] InputAction LoadScore;
    [SerializeField] InputAction TrySaveHighScore;

    GameState currentGameState;

    private void Start()
    {
        currentGameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
    }
    private void OnEnable()
    {
        IncreaseScore.Enable();
        DecreaseScore.Enable();
        ResetScore.Enable();
        SaveScore.Enable();
        LoadScore.Enable();
        TrySaveHighScore.Enable();
    }
    private void OnDisable()
    {
        IncreaseScore.Disable();
        DecreaseScore.Disable();
        ResetScore.Disable();
        SaveScore.Disable();
        LoadScore.Disable();
        TrySaveHighScore.Disable();
    }

    private void Update()
    {
        if (IncreaseScore.WasPressedThisFrame())
        {
            IncreaseCurrentScore();
        }
        if(DecreaseScore.WasPressedThisFrame())
        {
            DecreaseCurrentScore();
        }
        if (ResetScore.WasPressedThisFrame())
        {
            ResetCurrentScore();
        }
        if(SaveScore.WasPressedThisFrame())
        {
            SaveCurrentScore();
        }
        if(LoadScore.WasPressedThisFrame())
        {
            LoadCurrentScore();
        }
    }

    void IncreaseCurrentScore()
    {
        currentGameState.score += 1;
        Debug.Log($"Added to score, now {currentGameState.score}");
    }
    void DecreaseCurrentScore()
    {
        currentGameState.score -= 1;
        Debug.Log($"decreased to score, now {currentGameState.score}");
    }
    void ResetCurrentScore()
    {
        currentGameState.score = 0;
        Debug.Log($"Reset score, now {currentGameState.score}");
    }
    void SaveCurrentScore()
    {
        FindObjectOfType<GameSaveManager>().SaveToDisk();
    }
    void LoadCurrentScore()
    {
        FindObjectOfType<GameSaveManager>().LoadFromDisk();
        Debug.Log($"Loaded score, now {currentGameState.score}");
    }
}
