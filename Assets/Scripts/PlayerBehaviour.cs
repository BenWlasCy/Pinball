using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PaddleBehaviour paddleLeft;
    [SerializeField] PaddleBehaviour paddleRight;
    [SerializeField] Plunger plunger;

    [SerializeField] InputAction inputOneLeft;
    [SerializeField] InputAction inputTwoRight;
    [SerializeField] InputAction plungerInput;
    // Start is called before the first frame update

    private void OnEnable()
    {
        inputOneLeft.Enable();
        inputTwoRight.Enable();
        plungerInput.Enable();
    }

    private void OnDisable()
    {
        inputOneLeft.Disable();
        inputTwoRight.Disable();
        plungerInput.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        paddleLeft.Flip(inputOneLeft.IsPressed());
        paddleRight.Flip(inputTwoRight.IsPressed());
        plunger.DrawSpring(plungerInput.ReadValue<float>());
    }
}
