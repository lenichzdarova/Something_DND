using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLauncher : MonoBehaviour
{
    [SerializeField] PlayerMovement _player;
    private InputController _inputController;
    private UIController _ui; 
    private GameData _gameData;
    

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _inputController = new InputController();
        _player.Initialize(_inputController);
        _gameData = new GameData();
        _ui = new UIController(_inputController,_gameData.GetInventoryData());        
    }
}
