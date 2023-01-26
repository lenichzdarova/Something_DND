
using UnityEngine;

public interface IMovementInputsProvider
{
    PlayerInputs.MovementInputsActions GetMovementInputs();
}