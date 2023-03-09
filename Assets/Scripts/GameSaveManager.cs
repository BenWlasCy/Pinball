using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSaveManager : MonoBehaviour
{
    protected GameState gameState;
    string desiredPath;
    // UI reference
    [SerializeField] TMP_Text scoretext;
    private void Awake()
    {
        desiredPath = Path.Combine(Application.persistentDataPath, "PinballHighScore.txt");
        Debug.Log(desiredPath);
    }
    private void Start()
    {
        gameState = GameObject.FindObjectOfType<GameState>();
        // UI reference
    }
    private void Update()
    {
        scoretext.text = $"Score: {gameState.score.ToString()}";
    }

    public void LoadFromDisk()
    {

        if (File.Exists(desiredPath))
        {
            using (StreamReader streamReader = File.OpenText(desiredPath))
            {
                string jsonString = streamReader.ReadToEnd();

                JsonUtility.FromJsonOverwrite(jsonString, gameState);
            }
        }
    }

    public void SaveToDisk()
    {
        Debug.Log("Tried Saving");
        string jsonString = JsonUtility.ToJson(gameState);
        using (StreamWriter streamWriter = File.CreateText(desiredPath))
        {
            streamWriter.Write(jsonString);
            Debug.Log($"Saved {gameState.score}");
        }
    }
}
