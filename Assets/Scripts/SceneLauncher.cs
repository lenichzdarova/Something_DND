using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLauncher : MonoBehaviour
{
    [SerializeField] Player _player;
    private UISystem _ui; 
    private GameData _gameData;
    

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _ui = new UISystem(_player);
        _gameData = new GameData();
    }
}
