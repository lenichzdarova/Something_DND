
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// the highest player input layer class
/// handle inputs activation/deactivation depends on game state
/// 
/// possybly need to decompose by interfaces by action types
/// </summary>

public class InputController: IMovementInputsProvider
{    
    private PlayerInputs _inputs;
    private PlayerInputs.MovementInputsActions _moving;    

    public InputController()
    {        
        _inputs = new PlayerInputs();        
        _moving = _inputs.MovementInputs;
        _inputs.Enable();        
    }

    public Vector2 GetMovingVector()
    {
        return _moving.Move.ReadValue<Vector2>();
    }    
}
