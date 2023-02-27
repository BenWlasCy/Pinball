using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallReset : MonoBehaviour
{
    Rigidbody2D rigibody;
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            SetBallPosition(Camera.main.ScreenToWorldPoint(Mouse.current.position.value));
        }
    }

    public void SetBallPosition(Vector2 position)
    {
        rigibody.transform.position = position;
        rigibody.velocity = Vector2.zero;
    }
}
