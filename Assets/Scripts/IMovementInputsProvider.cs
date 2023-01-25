using UnityEngine.InputSystem;

public interface IMovementInputsProvider
{
    PlayerInputs.MovementInputsActions GetMovingActions();
}