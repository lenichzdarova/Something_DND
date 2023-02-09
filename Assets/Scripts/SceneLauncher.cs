using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private PlayerGroup _playerGroup;

    private Coroutine _gameUpdate;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _inputController = new InputController();
        _playerGroup = CreateTestPlayerGroup();

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

    private PlayerGroup CreateTestPlayerGroup()
    {
        PlayerGroup playerGroup = new PlayerGroup();
        playerGroup.AddCharacter(new Character(RaceEnum.Human,ClassEnum.Fighter,
            RaceAbilitiesProvider.GetAbilities(RaceEnum.Human)));
        return playerGroup;
    }
}
