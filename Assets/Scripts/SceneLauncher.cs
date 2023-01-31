using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this is core scene script 
/// initialize all other systems at first
/// than start corutine which contains update methods of all systems.
/// because with this aproach i can implicitly have monobehavior update in non mono classes 
/// </summary>

public class SceneLauncher : MonoBehaviour
{
    [SerializeField] PlayerMovement _player;
    [SerializeField] private UIController _ui;
    private InputController _inputController;    
    private PlayerData _gameData;

    private Coroutine _gameUpdate;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _inputController = new InputController();
        _gameData = new PlayerData();
        
        _player.Initialize(_inputController);        
        _ui.Initialize(_inputController);

        _gameUpdate = StartCoroutine(GameUpdate());
    }

    private IEnumerator GameUpdate()
    {
        while (true)
        {
            yield return null;
        }
    }
}
