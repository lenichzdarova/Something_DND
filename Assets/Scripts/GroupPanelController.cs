using System.Collections.ObjectModel;
using System.Collections.Generic;
using UnityEngine;

public class GroupPanelController : MonoBehaviour
{
    [SerializeField] CharacterButtonController _prefab;
    private List<CharacterButtonController> _characterButtons;
    private PlayerGroup _playerGroup;

    public void Initialize(PlayerGroup group)
    {
        _playerGroup = group;
        int maxCharacters = PlayerGroup.MAX_CHARACTER_COUNT;
        _characterButtons = new List<CharacterButtonController>();

        for(int i = 0; i < maxCharacters; i++)
        {
            var button = Instantiate(_prefab, transform);
            button.Initialize(i);
            _characterButtons.Add(button);
        }
        CharacterButtonsActivation(_playerGroup.GetCharacters());
        _playerGroup.GroupChanged += OnPlayerGroupChange;

    }

    public void CharacterButtonsActivation(ReadOnlyCollection<Character> characters)
    {
        int characterCount = characters.Count;
        for(int i = 0; i < _characterButtons.Count; i++)
        {
            if (i < characterCount)
            {
                _characterButtons[i].Activate(characters[i]);
            }
            else
            {
                _characterButtons[i].Deactivate();
            }
        }
    } 
    
    private void OnPlayerGroupChange()
    {
        CharacterButtonsActivation(_playerGroup.GetCharacters());
    }
}
