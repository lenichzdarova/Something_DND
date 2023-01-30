
using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButtonController : MonoBehaviour
{
    public event Action<int> ButtonClick;
    [SerializeField] private Image _portrait;
    [SerializeField] private Button _button;
    private int _buttonIndex;

    public void Initialize(int buttonIndex)
    {  
        _buttonIndex = buttonIndex;
        _button.onClick.AddListener(OnClick);
    }

    public void Activate(Character character)
    {
        SetPortrait(character._portrait);
    }

    public void Deactivate() 
    {
        _portrait = default;
    }

    private void SetPortrait(Sprite sprite)
    {
        _portrait.sprite = sprite;
    }

    private void OnClick()
    {
        ButtonClick?.Invoke(_buttonIndex);
    }
}
