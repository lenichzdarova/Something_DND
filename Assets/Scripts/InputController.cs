
using UnityEngine;

/// <summary>
/// the highest player input layer class
/// handle inputs activation/deactivation depends on game state
/// 
/// possybly need to decompose by interfaces by action types
/// </summary>

public class InputController: IMovementInputsProvider, IUIInputsProvider
{    
    private PlayerInputs _inputs;
    private PlayerInputs.MovementInputsActions _moving;
    private PlayerInputs.UIInputsActions _UI;

    public InputController()
    {        
        _inputs = new PlayerInputs();        
        _moving = _inputs.MovementInputs;
        _UI = _inputs.UIInputs;
        _inputs.Enable();        
    }

    public PlayerInputs.MovementInputsActions GetMovementInputs() { return _moving; }

    public PlayerInputs.UIInputsActions GetUIInputs() { return _UI; }
}
