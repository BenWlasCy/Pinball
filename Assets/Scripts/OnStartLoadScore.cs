using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartLoadScore : MonoBehaviour
{
    [SerializeField] GameSaveManager gameSaveManager;
    // Start is called before the first frame update
    void Start()
    {
        gameSaveManager.LoadFromDisk();
    }
}
