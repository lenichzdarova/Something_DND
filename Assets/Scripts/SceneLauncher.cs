using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLauncher : MonoBehaviour
{
    [SerializeField] PlayerMovement _player;
    [SerializeField] private UIController _ui;
    private InputController _inputController;    
    private PlayerData _gameData;
    

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _inputController = new InputController();
        _player.Initialize(_inputController);
        _gameData = new PlayerData();
        _ui.Initialize(_inputController, _gameData.GetInventoryData());        
    }
}
