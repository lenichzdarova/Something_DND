using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// player responsible for what?
/// in fact - camera position, camera rotation.
/// combat system will use player position and player collider as abstraction of player group;
/// 
/// player is a small system
/// camera  - view, transfrom  - data, player - controller? What subsystem class belogs to? 
/// </summary>

public class Player : MonoBehaviour
{
    private Transform _transfrom; 
    private Camera _cam;
    private IMovementInputsProvider _inputs;
    private float speed = 5f;

    public void Initialize(IMovementInputsProvider moveInputs)
    {
        _inputs = moveInputs;
    }

    private void Update()
    {
        Move(_inputs.GetMovingVector());
    }

    private void Move(Vector2 moveVector)
    {
        var movePosition = new Vector3(moveVector.x,0,moveVector.y);
        Debug.Log(movePosition);
        transform.position += movePosition * speed * Time.deltaTime;
    }

    private void Look()
    {

    }
}
