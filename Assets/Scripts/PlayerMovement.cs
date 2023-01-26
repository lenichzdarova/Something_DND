using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// player responsible for what?
/// in fact - camera position, camera rotation.
/// combat system will use player position and player collider as abstraction of player group;
/// 
/// player is a small system
/// camera  - view, transfrom  - data, player - controller? What subsystem class belogs to? 
/// </summary>

public class PlayerMovement : MonoBehaviour
{      
    private CharacterController _characterController;
    private PlayerInputs.MovementInputsActions _inputs;
    private float _moveSpeed = 5f;
    private float _mouseSensivity = 10f;

    private const float MAX_LOOK_ANGLE = 90f;

    public void Initialize(IMovementInputsProvider moveInputs)
    {
        _inputs = moveInputs.GetMovementInputs();        
        _inputs.Jump.performed += Jump;
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
        Look();        
    }

    private void Move()
    {
        var moveVector = _inputs.Move.ReadValue<Vector2>();
        var movePosition = (transform.forward * moveVector.y + transform.right * moveVector.x);        
        _characterController.Move(movePosition * _moveSpeed * Time.deltaTime);
    }

    private void Look()
    {
        var lookVector = _inputs.Look.ReadValue<Vector2>();
        float zAxisRotation = 0f;        

        float mouseX = lookVector.x * _mouseSensivity * Time.deltaTime;
        float mouseY = lookVector.y * _mouseSensivity * Time.deltaTime;
        Vector3 currentRotation = transform.rotation.eulerAngles;
        float lookAroundX = currentRotation.x -= mouseY;
        float lookAroundY = currentRotation.y += mouseX;
        var rotation = new Vector3(lookAroundX, lookAroundY, zAxisRotation);
        transform.rotation = Quaternion.Euler(rotation);      
    }

    private void Jump(InputAction.CallbackContext callback)
    {
       
    }
}
