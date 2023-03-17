using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnHit : MonoBehaviour
{
    private GameState currentGameState;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameObject.Find("GameState").GetComponent<GameState>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject)
        {
            currentGameState.UpdateScore(50);
        }
    }
}
