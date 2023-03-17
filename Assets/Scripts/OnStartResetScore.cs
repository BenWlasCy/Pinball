using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartResetScore : MonoBehaviour
{
    [SerializeField]GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState.score = 0;
    }
}
