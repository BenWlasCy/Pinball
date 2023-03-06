using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PaddleBehaviour paddleLeft;
    [SerializeField] PaddleBehaviour paddleRight;

    [SerializeField] InputAction inputOne;
    [SerializeField] InputAction inputTwo;
    // Start is called before the first frame update

    private void OnEnable()
    {
        inputOne.Enable();
        inputTwo.Enable();
    }

    private void OnDisable()
    {
        inputOne.Disable();
        inputTwo.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        paddleLeft.Flip(inputOne.IsPressed());
        paddleRight.Flip(inputTwo.IsPressed());
    }
}
