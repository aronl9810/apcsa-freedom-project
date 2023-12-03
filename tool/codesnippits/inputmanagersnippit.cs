// Everything that is not commented the "This was added" is default code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // This was added

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput; // This was added
    private PlayerInput.OnFootActions onFoot; // This was added
    private PlayerMotor motor; // This was added
    void Start()
    {
        playerInput = new PlayerInput(); // This was added
        onFoot = playerInput.OnFoot; // This was added
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void FixedUpdate() // Update --> FixedUpdate
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    public void OnEnable(){ // This was added
        onFoot.Enable();
    }
    public void OnDisable(){ // This was added
        onFoot.Disable();
    }
}