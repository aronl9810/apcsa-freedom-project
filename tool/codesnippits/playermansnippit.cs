// Everything that is not commented the "This was added" is default code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotto : MonoBehaviour
{
    private CharacterController controller; // This was added
    private Vector3 playerVelocity; // This was added
    public float speed = 5f; // This was added
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

// Basically this recieves input from InputManager.cs and apply them to our character controller
    public void ProcessMove(Vector2 input){ // This was added
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }
}